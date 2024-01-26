using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastoEfecto : MonoBehaviour
{
    public ParticleSystem particleSystem;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetTrigger("ActivateAnimation");
            particleSystem.Play();
            Debug.Log("Toca Pasto");
        }
        
    }
}
