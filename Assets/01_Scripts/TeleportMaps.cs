using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TeleportMaps : MonoBehaviour
{

    [SerializeField] public int level;
    [SerializeField] public bool levelBool;
    [SerializeField] private SpriteRenderer objeto;


    private void Start()
    {
        levelBool = false;
        objeto = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if ( levelBool == true)
        {
            objeto.color = Color.green;
        }
        else
        {
            objeto.color = Color.red;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && levelBool == true )
        {
            SceneManager.LoadScene(level);
        } 
    }
}
