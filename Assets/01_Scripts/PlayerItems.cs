using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerItems : MonoBehaviour
{

    public float bullets;
    [SerializeField] private TextMeshProUGUI textBullet;

    public float bulletsRifle;
    [SerializeField] private TextMeshProUGUI textRifle;

    public float bulletsShootgun;
    [SerializeField] private TextMeshProUGUI textShootgun;

    public float health;
    [SerializeField] private TextMeshProUGUI textHealth;

    public bool weaponCero;
    public bool weaponOne;
    public bool weaponTwo;
    public bool weaponTree;

    public Image weaponOneImg;
    public Image weaponTwoImg;
    public Image weaponTreeImg;

    public int weaponActive;



    private void Start()
    {
        //    textBullet = GetComponent<TextMeshProUGUI>();
        //    textHealth = GetComponent<TextMeshProUGUI>();
        
        
        weaponCero = true;
        weaponOne = false;
        weaponTwo = false;
        weaponTree = false;

    }

    private void Update()
    {
        float health = GameManager.Instance.health;

        textBullet.text = bullets.ToString("0");
        textHealth.text = health.ToString("0");
        textRifle.text = bulletsRifle.ToString("0");
        textShootgun.text = bulletsShootgun.ToString("0");

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
            weaponTwoImg.color = Color.grey;
            weaponTreeImg.color = Color.grey;

            weaponActive = 1;

            weaponOne = true;
            weaponTwo = false;
            weaponTree = false;
        }
    }

    void weaponTwoActive()
    {
        if( weaponTwoImg != null)
        {
            weaponOneImg.color = Color.grey;
            weaponTwoImg.color = Color.green;
            weaponTreeImg.color = Color.grey;

            weaponActive = 2;

            weaponOne = false;
            weaponTwo = true;
            weaponTree = false;
        }
    }

    void weaponTreeActive()
    {
        if( weaponTreeImg != null)
        {
            weaponOneImg.color = Color.grey;
            weaponTwoImg.color = Color.grey;
            weaponTreeImg.color = Color.green;

            weaponActive = 3;

            weaponOne = false;
            weaponTwo = false;
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
