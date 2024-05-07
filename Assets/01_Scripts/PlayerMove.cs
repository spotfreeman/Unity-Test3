using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] public float knockback = 10f;

    private Rigidbody2D playerRb;
    private float movX, movY;
    private Animator animator;

    [SerializeField] private bool stateMove;

    private void Start()
    {
        animator = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody2D>();

        stateMove = true;
    }

    private void Update()
    {
        if (stateMove == true)
        {
            movX = Input.GetAxisRaw("Horizontal");
            movY = Input.GetAxisRaw("Vertical");
        }

        animator.SetFloat("MovX", movX);
        animator.SetFloat("MovY", movY);

        if (movX != 0 || movY != 0)
        {
            animator.SetFloat("LastX", movX);
            animator.SetFloat("LastY", movY);
           
        }
        direction = new Vector2(movX, movY).normalized;
    }

    private void FixedUpdate()
    {
        float moveSpeed = GameManager.Instance.moveSpeed;

        playerRb.MovePosition(playerRb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && stateMove == true)
        {
            Debug.Log("Collision! " + stateMove);
            stateMove = false;
            Vector2 knockbackDirection = (transform.position - collision.transform.position).normalized;
            playerRb.AddForce(knockbackDirection * knockback, ForceMode2D.Impulse);
            Invoke("ResetStateMove", 0.5f); // Llama a ResetStateMove después de 0.5 segundos
        }
    }

    // Restablece stateMove a true después de un tiempo
    private void ResetStateMove()
    {
        stateMove = true;
        Debug.Log("Fin del Codigo");
    }
}

