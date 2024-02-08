using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponOne : MonoBehaviour
{

    public float bulletShoot;
    public float coldDownCounter;

    void Start()
    {
        
    }

   
    void Update()
    {
        int enable = GameManager.Instance.weaponOne_Enable;
        float bullets = GameManager.Instance.weaponOne_Bullets;
        float coldDown = GameManager.Instance.weaponOne_ColdDown;
        float damage = GameManager.Instance.weaponOne_Damage;

        coldDownCounter = coldDown;
        coldDownCounter -= Time.fixedDeltaTime ;
        

        if (Input.GetKeyDown("Fire1") && enable == 1)
        {
            Debug.Log(" Ejecutar acciones de Weapon ONE");

            if ( coldDownCounter < 0 )
            {
                
                if (bullets > 0)
                {
                    GameManager.Instance.WeaponOneRest(bulletShoot);
                    coldDownCounter = coldDown;
                }
            }

            
        }
    }


}
