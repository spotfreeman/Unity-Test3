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

    [Header("Weapon Stats")]
    // Nueva Estructura
    [Header("Weapon One")]
    [SerializeField] public int weaponOne_Enable;
    [SerializeField] public float weaponOne_Bullets;
    [SerializeField] public float weaponOne_ColdDown;
    [SerializeField] public float weaponOne_Damage;

    [Header("Weapon Two")]
    [SerializeField] public int weaponTwo_Enable;
    [SerializeField] public float weaponTwo_Bullets;

    [Header("Weapon Three")]
    [SerializeField] public int weaponThree_Enable;
    [SerializeField] public float weaponThree_Bullets;

    [Header("Items ")]
    [SerializeField] public float gold;

    // BOSS
    [Header("BOSS")]
    [SerializeField] public bool EntradaOculta = true;
    [SerializeField] public bool PasajesLaberinticos = true;
    [SerializeField] public bool SalasDePruebas = true;
    [SerializeField] public bool GuardianesAntiguos = true;
    [SerializeField] public bool CamarasDeSacrificio = true;
    [SerializeField] public bool CamaraDelNigromante = true;

    // UI

    [SerializeField] private Barradevida barra;

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
        barra.IniciarBarra(maxHealth);

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
    public void WeaponOneEnable(int value)
    {
        weaponOne_Enable = value;
    }

    public void WeaponOneAdd(float value)
    {
        weaponOne_Bullets += value;
    }

    public void WeaponOneRest(float value)
    {
        weaponOne_Bullets -= value;
    }


    private void Update()
    {
        barra.CambiarVidaActual(health);
        barra.CambiarVidaMaxima(maxHealth);
    }
    // Energia jugador

    public void AddHealth(float value)
    {
        
        health += value;
        if( health >= maxHealth )
        {
            health = maxHealth;
        }
        barra.CambiarVidaActual(health);

    }

    public void DamageHealth(float value)
    {
        health -= value;
        barra.CambiarVidaActual(health);
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
        PlayerPrefs.SetFloat("SlotA-Health", 3);
        PlayerPrefs.SetFloat("SlotA-MaxHealth", 10);
        PlayerPrefs.SetFloat("SlotA-MoveSpeed", 2);
        health = PlayerPrefs.GetFloat("SlotA-Health");
        maxHealth = PlayerPrefs.GetFloat("SlotA-MaxHealth");
        moveSpeed = PlayerPrefs.GetFloat("SlotA-MoveSpeed");
    }

    public void ResetDataSlotB()
    {
        slotActive = 2;
        PlayerPrefs.SetFloat("SlotB-Health", 5);
        PlayerPrefs.SetFloat("SlotB-MaxHealth", 10);
        PlayerPrefs.SetFloat("SlotB-MoveSpeed", 2);
        health = PlayerPrefs.GetFloat("SlotB-Health");
        maxHealth = PlayerPrefs.GetFloat("SlotB-MaxHealth");
        moveSpeed = PlayerPrefs.GetFloat("SlotB-MoveSpeed");
    }
}
