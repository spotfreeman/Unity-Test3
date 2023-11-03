using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speedMovement;
    [SerializeField] private Vector2 direction;

    private Rigidbody2D playerRb;
    private float movX, movY;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
        movY = Input.GetAxisRaw("Vertical");

        animator.SetFloat("MovX", movX);
        animator.SetFloat("MovY", movY);

        if(movX != 0 || movY != 0)
        {
            animator.SetFloat("LastX", movX);
            animator.SetFloat("LastY", movY);
        }
        direction = new Vector2(movX, movY).normalized;
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + direction * speedMovement * Time.fixedDeltaTime);
    }
}
