using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    SpriteRenderer spriteNpc;

    private void Start()
    {
        spriteNpc = GetComponent<SpriteRenderer>();
        spriteNpc.color = Color.green;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player Entry");
        spriteNpc.color = Color.yellow;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player Exit");
        spriteNpc.color = Color.green;
    }
}
