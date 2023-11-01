using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerItems : MonoBehaviour
{

    public float bullets;
    [SerializeField] private TextMeshProUGUI textBullet;

    public float health;
    [SerializeField] private TextMeshProUGUI textHealth;

    private void Start()
    {
        //    textBullet = GetComponent<TextMeshProUGUI>();
        //    textHealth = GetComponent<TextMeshProUGUI>();
        health = 50f;
    }

    private void Update()
    {

        textBullet.text = bullets.ToString("0");
        textHealth.text = health.ToString("0");
        
    }

    public void AllBullets(float bulletsTaken)
    {
        bullets += bulletsTaken;
    }

    public void ShootBullet(float bulletsShoots)
    {
        bullets -= bulletsShoots;
    }




    public void HealthCount(float healthTaken)
    {
        health += healthTaken;
    }

}
