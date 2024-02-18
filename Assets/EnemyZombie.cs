using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombie : MonoBehaviour
{
    public Transform player; // Asigna el jugador en el Inspector
    public float followSpeed = 5f; // Velocidad a la que sigue al jugador

    void Start()
    {
        // Asegúrate de que el jugador esté asignado
        if (player == null)
        {
            Debug.LogError("Player not assigned to FollowPlayer script!");
        }
    }

    void Update()
    {
        // Solo sigue al jugador si está asignado
        if (player != null)
        {
            // Código para seguir al jugador con la velocidad especificada
            transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * followSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que entra en el trigger es el jugador
        if (other.CompareTag("Player"))
        {
            // Asigna el jugador al objeto para que comience a seguirlo
            player = other.transform;
        }
    }
}
