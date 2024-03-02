using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombieV2 : MonoBehaviour
{
    [SerializeField] private Transform player;
    private bool isFacingRight = true;
    [SerializeField] private float speed;
    [SerializeField] private float health;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position ,speed * Time.deltaTime);

        bool playerRight = transform.position.x < player.transform.position.x;
        Flip(playerRight);

        anim.SetBool("Walk", true);

        if( health <= 0)
        {
            Destroy(gameObject);
        }



    }

    private void Flip(bool playerRight)
    {
        if (( isFacingRight && !playerRight ) || ( !isFacingRight && playerRight ))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shoot"))
        {
            health--; 
        }
    }
}
