using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaves : MonoBehaviour
{
    [SerializeField] public string slotA;
    [SerializeField] public float health;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveData()
    {
        float health = GameManager.Instance.health;
        float maxHealth = GameManager.Instance.maxHealth;

        PlayerPrefs.SetFloat("Health", health);
        PlayerPrefs.SetFloat("MaxHealth", maxHealth);

        
    }

    public void LoadData()
    {
        PlayerPrefs.GetFloat("Health");
        PlayerPrefs.GetFloat("MaxHealth");
    }

    public void ResetData()
    {

        PlayerPrefs.SetFloat("Health", 30);
        PlayerPrefs.SetFloat("MaxHealth", 40);


    }
}
