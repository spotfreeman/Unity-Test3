using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private Vector2 direction;
    [SerializeField] public float knockback = 3f;

    private Rigidbody2D playerRb;
    private float movX, movY;
    private Animator animator;

    [SerializeField] ParticleSystem particula;

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
            particula.Play();
        }
        direction = new Vector2(movX, movY).normalized;
    }

    private void FixedUpdate()
    {
        float moveSpeed = GameManager.Instance.moveSpeed;

        playerRb.MovePosition(playerRb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Collision! ");
            Vector2 knockbackDirection = (transform.position - collision.transform.position).normalized;
            playerRb.AddForce(knockbackDirection * knockback, ForceMode2D.Impulse);
            Debug.Log("Fin del Codigo");
        }
        
    }
}
