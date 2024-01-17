using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{ 

 

    public void SaveData()
    {

        // PLAYER STATS

        float maxHealth = GameManager.Instance.maxHealth;
        float health = GameManager.Instance.health;
        
        PlayerPrefs.SetFloat("MAXHEALTH", maxHealth);
        PlayerPrefs.SetFloat("HEALTH", health);

        // BOSS STATS



    }

    public void LoadData()
    {
        PlayerPrefs.GetFloat("MAXHEALTH");
        PlayerPrefs.GetFloat("HEALTH");

    }
}
