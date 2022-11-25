using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class JerryMovement : MonoBehaviour
{
    //Alternate: public Transform groundCheckTransform = null;
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    //[SerializeField] private CharacterController controller;
    public bool jumpKeyPressed;
    private float horizontalInput;
    private float verticalInput;
    public float speed = 1.5f;
    private Rigidbody rigidbodyComponent;
    public float jumpheight = 2.0f;


    public new Transform camera;
    public bool jumpReady = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            //Print statement
            //Debug.Log("Space key was pressed.");

            jumpKeyPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Free movement with camera
        Vector3 input = new Vector3(horizontalInput, 0, verticalInput).normalized;
        float cameraRot = Camera.main.transform.rotation.eulerAngles.y;
        rigidbodyComponent.position += Quaternion.Euler(0, cameraRot, 0) * input * speed * Time.deltaTime;

        //Attempted Rotation
        if (input.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(input.x, input.z) * Mathf.Rad2Deg + cameraRot;
            transform.rotation = Quaternion.Euler(0, targetAngle, 0);
        }



        //Checks for collision on the character's feet to allow for jumps
        if (Physics.OverlapSphere(groundCheckTransform.position, 1.0f, playerMask).Length == 0)
        {
            jumpKeyPressed = false;
            //Increases speed mid air
            //rigidbodyComponent.velocity = new Vector3(horizontalInput * 4, rigidbodyComponent.velocity.y, 0);
            return;
        }

        //Checks jump
        if (jumpKeyPressed == true && jumpReady)
        {
            //Print statement
            Debug.Log("Space key was pressed.");

            //Adjusts jump height
            rigidbodyComponent.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
            //Debug.Log(rigidbodyComponent)

            //jumpKeyPressed = false;
            return;
        }
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8 || other.gameObject.layer == 7)
        {
            jumpReady = true;
            jumpKeyPressed = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8 || other.gameObject.layer == 7)
        {
            jumpReady = false;
        }
        
    }
}
