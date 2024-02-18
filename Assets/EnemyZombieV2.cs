using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombieV2 : MonoBehaviour
{
    [SerializeField] private Transform player;
    private bool isFacingRight = true;
    [SerializeField] private float speed;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position ,speed * Time.deltaTime);

        bool playerRight = transform.position.x < player.transform.position.x;
        Flip(playerRight);


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
}
