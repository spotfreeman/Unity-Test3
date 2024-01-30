using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponOne : MonoBehaviour
{



    void Start()
    {
        
    }

   
    void Update()
    {
        int enable = GameManager.Instance.weaponOne_Enable;
        float bullets = GameManager.Instance.weaponOne_Bullets;
        float coldDown = GameManager.Instance.weaponOne_ColdDown;
        float damage = GameManager.Instance.weaponOne_Damage;

        if (Input.GetKeyDown("Fire1") && enable == 1)
        {
            Debug.Log(" Ejecutar acciones de Weapon ONE");

            if ( bullets > 0 )
            {
                bullets--;

                if ( coldDown < 0)
                {

                }

            }
        }
    }


}
