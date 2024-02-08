using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item_Bullet : MonoBehaviour
{
    
    private bool pickItem;
    [SerializeField] public float bulletsTaken;
    


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
            // Opcion de colocar texto

            pickItem = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            pickItem = false;
        }
    }

    void Pick()
    {
        GameManager.Instance.WeaponOneAdd(bulletsTaken);
        Destroy(gameObject);
    }
}
