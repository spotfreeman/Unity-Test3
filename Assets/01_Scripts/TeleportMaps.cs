using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeleportMaps : MonoBehaviour
{

    [SerializeField] public int level;
    [SerializeField] public bool levelBool;

    public SpriteRenderer portal;

    private void Start()
    {
        levelBool = false;
        portal = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if ( levelBool == true)
        {
            portal.color = Color.green;
        }
        else
        {
            portal.color = Color.red;
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
