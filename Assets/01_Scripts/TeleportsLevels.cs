using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportsLevels : MonoBehaviour
{
    public SpriteRenderer spriteTeleport;

    [SerializeField] public bool teleportOne;


    private void Start()
    {
        spriteTeleport = GetComponent<SpriteRenderer>();
        spriteTeleport.color = Color.red;
    }

    private void Update()
    {
        teleportOne = GameManager.Instance.EntradaOculta;

        if (teleportOne == true)
        {
            spriteTeleport.color = Color.green;

        }
        else
        {
            spriteTeleport.color = Color.red;
        }
    }
}
