using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    // GLOBALES
    [Header("GLOBALES")]
    [SerializeField] public float timesPlayed;
    [SerializeField] public int slotActive;

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
    // Nueva Estructura
    [SerializeField] public int weaponOne_Enable;
    [SerializeField] public float weaponOne_Bullets;
    [SerializeField] public float weaponOne_ColdDown;
    [SerializeField] public float weaponOne_Damage;
 
    // Antigua estructura
    [SerializeField] public float bulletsOne;
    [SerializeField] public float bulletsTwo;
    [SerializeField] public float bulletsThree;

    [SerializeField] public float gold;

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

    private void Start()
    {
        timesPlayed = PlayerPrefs.GetFloat("TimesPlayed");

        if (timesPlayed == 0)
        {
            PlayerPrefs.SetFloat("SlotA-Health", 30);
            PlayerPrefs.SetFloat("SlotA-MaxHealth", 40);
            PlayerPrefs.SetFloat("SlotA-MoveSpeed", 2);

            PlayerPrefs.SetFloat("SlotB-Health", 50);
            PlayerPrefs.SetFloat("SlotB-MaxHealth", 60);
            PlayerPrefs.SetFloat("SlotB-MoveSpeed", 2);

            timesPlayed++;

            PlayerPrefs.SetFloat("TimesPlayed", timesPlayed);

        }
        else
        {
            timesPlayed++;
            PlayerPrefs.SetFloat("TimesPlayed", timesPlayed);
        }


        slotActive = PlayerPrefs.GetInt("SlotActive");
        if (slotActive == 1)
        {
            health = PlayerPrefs.GetFloat("SlotA-Health");
            maxHealth = PlayerPrefs.GetFloat("SlotA-MaxHealth");
            moveSpeed = PlayerPrefs.GetFloat("SlotA-MoveSpeed");
        }
        if (slotActive == 2)
        {
            health = PlayerPrefs.GetFloat("SlotB-Health");
            maxHealth = PlayerPrefs.GetFloat("SlotB-MaxHealth");
            moveSpeed = PlayerPrefs.GetFloat("SlotB-MoveSpeed");
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




    public void LoadDataSlotA()
    {
        slotActive = 1;
        PlayerPrefs.SetInt("SlotActive", slotActive);
        health = PlayerPrefs.GetFloat("SlotA-Health");
        maxHealth = PlayerPrefs.GetFloat("SlotA-MaxHealth");
        moveSpeed = PlayerPrefs.GetFloat("SlotA-MoveSpeed");
    }

    public void LoadDataSlotB()
    {
        slotActive = 2;
        PlayerPrefs.SetInt("SlotActive", slotActive);
        health = PlayerPrefs.GetFloat("SlotB-Health");
        maxHealth = PlayerPrefs.GetFloat("SlotB-MaxHealth");
        moveSpeed = PlayerPrefs.GetFloat("SlotB-MoveSpeed");
    }

    public void ResetDataSlotA()
    {
        slotActive = 1;
        PlayerPrefs.SetFloat("SlotA-Health", 10);
        PlayerPrefs.SetFloat("SlotA-MaxHealth", 10);
        PlayerPrefs.SetFloat("SlotA-MoveSpeed", 2);
        health = PlayerPrefs.GetFloat("SlotA-Health");
        maxHealth = PlayerPrefs.GetFloat("SlotA-MaxHealth");
        moveSpeed = PlayerPrefs.GetFloat("SlotA-MoveSpeed");
    }

    public void ResetDataSlotB()
    {
        slotActive = 2;
        PlayerPrefs.SetFloat("SlotB-Health", 20);
        PlayerPrefs.SetFloat("SlotB-MaxHealth", 20);
        PlayerPrefs.SetFloat("SlotB-MoveSpeed", 3);
        health = PlayerPrefs.GetFloat("SlotB-Health");
        maxHealth = PlayerPrefs.GetFloat("SlotB-MaxHealth");
        moveSpeed = PlayerPrefs.GetFloat("SlotB-MoveSpeed");
    }
}
