using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item_Bullet : MonoBehaviour
{
    [SerializeField] public TMP_Text textItem;
    private bool pickItem;

    [SerializeField] private float bulletsTaken;
    [SerializeField] private PlayerItems playeritem;

    private void Start()
    {
        textItem.gameObject.SetActive(false);
    }

    private void Update()
    {
        if( pickItem && Input.GetButtonDown("Fire3"))
        {
            Pick();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textItem.gameObject.SetActive(true);
            pickItem = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textItem.gameObject.SetActive(false);
            pickItem = false;
        }
    }

    void Pick()
    {
        playeritem.AllBullets(bulletsTaken);
        Destroy(gameObject);
    }
}
