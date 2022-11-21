using System;
using Cinemachine;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform player;
    public Transform playerObject;
    public Rigidbody rb;
    public Transform lookAt;
    public CinemachineFreeLook FreeLook;

    public float rotationSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector3 viewDir = lookAt.position -
                          new Vector3(transform.position.x, lookAt.position.y, transform.position.z);
        orientation.forward = viewDir.normalized;
    
        playerObject.forward = viewDir.normalized;
    }
}