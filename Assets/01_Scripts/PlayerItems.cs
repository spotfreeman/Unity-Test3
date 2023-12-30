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

    public bool weaponCero;
    public bool weaponOne;
    public bool weaponTwo;
    public bool weaponTree;

    public Image weaponOneImg;
    public Image weaponTwoImg;
    public Image weaponTreeImg;



    private void Start()
    {
        //    textBullet = GetComponent<TextMeshProUGUI>();
        //    textHealth = GetComponent<TextMeshProUGUI>();
        health = 50f;
        weaponCero = true;
        weaponOne = false;
        weaponTwo = false;
        weaponTree = false;

    }

    private void Update()
    {


        textBullet.text = bullets.ToString("0");
        textHealth.text = health.ToString("0");


        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponOneActive();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponTwoActive();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponTreeActive();
        }
        

    }


    void weaponOneActive()
    {
        if( weaponOneImg != null)
        {
            weaponOneImg.color = Color.green;
            weaponOne = true;
        }
    }

    void weaponTwoActive()
    {
        if( weaponTwoImg != null)
        {
            weaponTwoImg.color = Color.green;
            weaponTwo = true;
        }
    }

    void weaponTreeActive()
    {
        if( weaponTreeImg != null)
        {
            weaponTreeImg.color = Color.green;
            weaponTree = true;
        }
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

    public void HealthDamage(float healthDamage)
    {
        health -= healthDamage;
    }

}
