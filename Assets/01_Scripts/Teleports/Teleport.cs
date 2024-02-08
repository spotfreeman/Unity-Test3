using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject portal_one_object_enable = GameObject.Find("PortalOne_Enable");
    [SerializeField] GameObject portal_one_object_disable = GameObject.Find("PortalOne_Disable");

    void Start()
    {

    }


    void Update()
    {
        if (GameManager.Instance.EntradaOculta == true)
        {
           
            portal_one_object_enable.SetActive(true);
            portal_one_object_disable.SetActive(false);
        }
        else
        {
           
            portal_one_object_enable.SetActive(false);
            portal_one_object_disable.SetActive(true);
        }
    }


}
