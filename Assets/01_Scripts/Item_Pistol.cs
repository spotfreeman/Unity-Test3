using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pistol : MonoBehaviour
{
    private bool pickItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        GameManager.Instance.WeaponOneEnable(1);
        Destroy(gameObject);
    }

}
