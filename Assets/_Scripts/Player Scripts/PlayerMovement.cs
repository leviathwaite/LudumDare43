using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode keyUp;
    public KeyCode keyDown;
    public KeyCode keyLeft;
    public KeyCode keyRight;

    [SerializeField]
    private float walkingSpeed = 5;
    [SerializeField]
    private float runningSpeed = 10;

    private float currentSpeed;
    private Vector3 movementDirection;
    private bool isRunning = false;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetInput();
        CheckSpeed();
    }

    private void GetInput()
    {
        if (Input.GetKey(keyUp))
        {
            movementDirection = Vector3.forward;
        }

        if (Input.GetKey(keyDown))
        {
            movementDirection = Vector3.back;
        }

        if (Input.GetKey(keyLeft))
        {
            movementDirection = Vector3.left;
        }

        if (Input.GetKey(keyRight))
        {
            movementDirection = Vector3.right;
        }
    }

    private void CheckSpeed()
    {
        isRunning = Input.GetKey(KeyCode.LeftShift);

        if(isRunning)
        {
            currentSpeed = runningSpeed;
        }
        else
        {
            currentSpeed = walkingSpeed;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.MovePosition(transform.position + (movementDirection * currentSpeed * Time.fixedDeltaTime));
        movementDirection = Vector3.zero;
    }
}
