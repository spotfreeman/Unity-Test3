using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PrimaryAction();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            SecondAction();
        }

        if (Input.GetButtonDown("Fire3"))
        {
            DragAction();
        }
    }

    void PrimaryAction()
    {
        Debug.Log("Primary Accion");
        animator.SetBool("Attack_Up", true);
        

    }

    void SecondAction()
    {
        Debug.Log("Second Action");
    }
    void DragAction()
    {
        Debug.Log("Take Item");
    }
}
