using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 3f;
    public float gravity = -20f;

    public float rotateSpeed = 500f;
    private float mx = 0f;
    private float my = 0f;

    private Vector2 moveInput;
    private float verticalVelocity;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if(value.isPressed && controller.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }

    void Update()
    {
        if (controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        move = move * moveSpeed;
        move.y = verticalVelocity;

        controller.Move(move * moveSpeed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        mx += mouseX * rotateSpeed * Time.deltaTime;
        my += mouseY * rotateSpeed * Time.deltaTime;

        my = Mathf.Clamp(my, -90f, 90f);

        transform.localEulerAngles = new Vector3(-my, mx, 0);
    }
}
