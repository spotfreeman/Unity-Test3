using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerSaves : MonoBehaviour
{
    [SerializeField] public int slotA;
    [SerializeField] public int slotB;
    [SerializeField] public int slot;
    
    [SerializeField] public TextMeshProUGUI textSlot;

    void Start()
    {
        textSlot.text = slot.ToString("");
        slotA = 0;
        slotB = 0;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            slotA = 1;
            slotB = 0;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            slotA = 0;
            slotB = 1;
        }

        

        if (slotA == 1)
        {
            textSlot.text = slot.ToString("1");

        }

        if (slotB == 1)
        {
            textSlot.text = slot.ToString("2");
        }


    }

    public void SaveData()
    {
        float health = GameManager.Instance.health;
        float maxHealth = GameManager.Instance.maxHealth;

        if (slotA == 1)
        {
            Debug.Log("Datos Guardados en SLOT A");


            PlayerPrefs.SetFloat("SlotA-Health", health);
            PlayerPrefs.SetFloat("SlotA-MaxHealth", maxHealth);

        }

        if(slotB == 1)
        {
            Debug.Log("Datos guadados en SLOT B");


            PlayerPrefs.SetFloat("SlotB-Health", health);
            PlayerPrefs.SetFloat("SlotB-MaxHealth", maxHealth);
        }
    }


    public void LoadData()
    {
        // los datos se cargan desde el GAMEMANAGER 
    }


}
