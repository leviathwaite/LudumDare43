using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Animator anim;
    private Rigidbody rb;

    private Vector3 prevPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementSpeed = rb.velocity.magnitude;
        UpdateAnimator(movementSpeed);
    }
    

    private void UpdateAnimator(float moveSpeed)
    {
        anim.SetFloat("movement", playerMovement.GetCurrentSpeed());
        // Debug.Log("move speed: " + playerMovement.GetCurrentSpeed());
    }
}
