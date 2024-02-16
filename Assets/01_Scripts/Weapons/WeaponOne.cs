using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponOne : MonoBehaviour
{
    [SerializeField] public int enable;
    [SerializeField] public float bulletShoot;
    [SerializeField] public float damage;

    [SerializeField] public float coldDown_Counter;
    [SerializeField] public float coldDown_Limit;


    // Creando disparo basico
    public Transform firePoint; // Punto desde donde se dispararán los proyectiles
    public GameObject projectilePrefab;
    // end


    void Start()
    {
        bulletShoot = GameManager.Instance.weaponOne_Bullets;
        coldDown_Counter = GameManager.Instance.weaponOne_ColdDown;
        damage = GameManager.Instance.weaponOne_Damage;
        coldDown_Limit = GameManager.Instance.weaponOne_ColdDown;
    }


    void Update()
    {
        enable = GameManager.Instance.weaponOne_Enable;

        if (coldDown_Counter > 0)
        {
            coldDown_Counter -= Time.deltaTime;
        }
        else
        {
            coldDown_Counter = 0;
        }



        if (Input.GetButtonDown("Fire1"))
        {
            if (enable == 1)
            {
                Debug.Log(" Arma Habilitada ");

                // Funcion de disparar

                if (bulletShoot > 0)
                {
                    if (coldDown_Counter <= 0)
                    {
                        Debug.Log(" Disparo! ");

                        coldDown_Counter = coldDown_Limit;

                        Shoot();



                    }
                    else
                    {
                        Debug.Log(" Estoy cansado...");
                    }
                }
                else
                {
                    Debug.Log(" Sin Balas! ");
                }
            }
            else
            {
                Debug.Log(" Arma no habilitada ");
            }




        }

    }

    void Shoot()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        Vector2 shootDirection = (mousePosition - transform.position).normalized;

        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = shootDirection * 25f;
    }
}
