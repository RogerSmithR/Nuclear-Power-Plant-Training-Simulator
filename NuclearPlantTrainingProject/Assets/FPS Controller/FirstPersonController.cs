using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonController : MonoBehaviour
{
    private CharacterController controller;

    private PlayerInput playerInput;
    private InputAction mouseXAction;
    private InputAction mouseYAction;
    private InputAction moveXZAction;
    private InputAction moveYAction;

    public float keyboardSensitivity;
    public float mouseSensitivity;

    private float xRotation = 0f;
    private float yRotation = 0f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
        mouseXAction = playerInput.actions["MouseX"];
        mouseYAction = playerInput.actions["MouseY"];
        moveXZAction = playerInput.actions["MoveXZ"];
        moveYAction = playerInput.actions["MoveY"];
    }

    void Update()
    {
        float MouseX = mouseXAction.ReadValue<float>();
        float MouseY = mouseYAction.ReadValue<float>();
        Vector2 moveXZ = moveXZAction.ReadValue<Vector2>();
        float moveY = moveYAction.ReadValue<float>();

        xRotation -= MouseY * mouseSensitivity * Time.deltaTime;

        yRotation += MouseX * mouseSensitivity * Time.deltaTime;
        
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        //transform.Rotate(Vector3.up, yRotation);

        Vector3 move = transform.right * moveXZ.x + transform.forward * moveXZ.y + transform.up * moveY;

        controller.Move(move * keyboardSensitivity * Time.deltaTime);        
    }
}
