using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item_Health : MonoBehaviour
{
    private bool pickItem;

    [SerializeField] private float healthTaken;

    private void Start()
    {
       
    }

    private void Update()
    {
        if (pickItem && Input.GetButtonDown("Fire3"))
        {
            Pick();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            pickItem = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           
            pickItem = false;
        }
    }

    void Pick()
    {
        GameManager.Instance.AddHealth(healthTaken);
        Destroy(gameObject);
    }
}
