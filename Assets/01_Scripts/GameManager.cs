using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    // OPTIONS
    [Header ("OPTIONS")]
    [SerializeField] private float musicControl;
    [SerializeField] private float soundControl;

    // PLAYER
    [Header("PLAYER")]
    [SerializeField] public float maxHealth;
    [SerializeField] public float health;

    [SerializeField] public float moveSpeed;

    [SerializeField] public float attackSpeed;
    [SerializeField] public float attackMelee;


    [SerializeField] public float damageMelee;
    [SerializeField] public float damageRange;

    [Header("BULLETS")]
    [SerializeField] public float bulletsOne;
    [SerializeField] public float bulletsTwo;
    [SerializeField] public float bulletsThree;


    // BOSS
    [Header("BOSS")]
    [SerializeField] public bool EntradaOculta = true;
    [SerializeField] public bool PasajesLaberinticos = true;
    [SerializeField] public bool SalasDePruebas = true;
    [SerializeField] public bool GuardianesAntiguos = true;
    [SerializeField] public bool CamarasDeSacrificio = true;
    [SerializeField] public bool CamaraDelNigromante = true;


    private void Awake()
    {
        if( Instance == null)
        {
            Instance = this;
        }
        
        else
        {
            Debug.Log("Error : GameManager duplicado");
        }
    }


    // Funciones de actualizacion

    // Arma uno

    public void AddBulletOne(float value)
    {
        bulletsOne += value;
    }

    public void ShootBullerOne(float value)
    {
        bulletsOne -= value;
    }


    // Energia jugador

    public void AddHealth(float value)
    {
        health += value;
        if( health >= maxHealth )
        {
            health = maxHealth;
        }

    }

    public void DamageHealth(float value)
    {
        health -= value;
    }



}
