using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Stats : MonoBehaviour
{
    [SerializeField] public float energy;



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if( energy <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Attack"))
        {
            
        }
    }
}
