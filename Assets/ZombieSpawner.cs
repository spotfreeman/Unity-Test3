using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] pointsSpawn;
    [SerializeField] private float timerChange = 3f;


    private void Update()
    {
        timerChange -= Time.deltaTime;

        if( timerChange <= 0)
        {
            timerChange = 3f;
        }
    }
}
