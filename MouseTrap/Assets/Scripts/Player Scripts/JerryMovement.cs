using System;
using Cinemachine;
using TMPro;
using UnityEngine;

    public class JerryMovement : MonoBehaviour
    {
        [Header("Movement")]
        public float speed;

        public float groundDrag;
        
        public float jumpForce;
        public float jumpCooldown;
        public bool canJump;
        
        [Header("keybinds")]
        public KeyCode jumpKey;
        
        [Header("Ground Check")]
        public float playerHeight;
        public LayerMask groundLayer;
        bool isGrounded;
        

        [SerializeField] private Transform LookAt;

        public Transform orientation;
        
        float horizontalInput;
        float verticalInput;
        
        Vector3 moveDirection;
        
        Rigidbody rb;
        
        CinemachineVirtualCamera camera;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            camera = GameObject.Find("CM FreeLook1").GetComponent<CinemachineVirtualCamera>();
            rb.freezeRotation = true;
        }
        
        private void Update()
        {
            isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, groundLayer);
            MyInput();
            SpeedControl();

            if (isGrounded)
            {
                rb.drag = groundDrag;
            }
            else
            {
                rb.drag = 0.1f;
            }
        }
        
        private void FixedUpdate()
        {
            MovePlayer();
        }
        
        private void MyInput()
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");
            
            if(Input.GetKeyDown(jumpKey) && isGrounded && canJump)
            {
                Jump();
            }

            moveDirection = (orientation.forward * verticalInput) + (orientation.right * horizontalInput);
            moveDirection.Normalize();
        }

        private void MovePlayer()
        {
            moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
            
            rb.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);
        }
        
        private void SpeedControl()
        {
            if (rb.velocity.magnitude > speed)
            {
                rb.velocity = rb.velocity.normalized * speed;
            }
        }
        
        private void Jump()
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
            Invoke(nameof(ResetJump), jumpCooldown);

        }
        
        private void ResetJump()
        {
            canJump = true;
        }
    }
