using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;
    public Vector2 shootingDirection = Vector2.right;

    [SerializeField] private PlayerItems playeritem;
    private float ShootDiscount = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        float bulletStatus = playeritem.bullets;
        int weapon = playeritem.weaponActive;


        if (weapon == 1)
        {
            if (bulletStatus > 0)
            {

                playeritem.ShootBullet(ShootDiscount);

                // Convertir la posición del mouse de coordenadas de pantalla a coordenadas del mundo
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 shootingDirection = (mousePosition - transform.position).normalized;

                // Ignora la componente z para disparos en 2D
                // shootingDirection.z = 0;

                // Crea el proyectil en la posición del jugador
                GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                // Asigna la velocidad al proyectil en la dirección calculada
                projectile.GetComponent<Rigidbody2D>().velocity = shootingDirection * projectileSpeed;
            }
        }
        if (weapon == 2)
        {
            if (bulletStatus > 0)
            {

                playeritem.ShootBullet(ShootDiscount);

                // Convertir la posición del mouse de coordenadas de pantalla a coordenadas del mundo
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 shootingDirection = (mousePosition - transform.position).normalized;

                // Ignora la componente z para disparos en 2D
                // shootingDirection.z = 0;

                // Crea el proyectil en la posición del jugador
                GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                // Asigna la velocidad al proyectil en la dirección calculada
                projectile.GetComponent<Rigidbody2D>().velocity = shootingDirection * projectileSpeed;
            }
        }
        if (weapon == 2)
        {
            if (bulletStatus > 0)
            {

                playeritem.ShootBullet(ShootDiscount);

                // Convertir la posición del mouse de coordenadas de pantalla a coordenadas del mundo
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 shootingDirection = (mousePosition - transform.position).normalized;

                // Ignora la componente z para disparos en 2D
                // shootingDirection.z = 0;

                // Crea el proyectil en la posición del jugador
                GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                // Asigna la velocidad al proyectil en la dirección calculada
                projectile.GetComponent<Rigidbody2D>().velocity = shootingDirection * projectileSpeed;
            }
        }

        else
        {
            Debug.Log("Sin Munucion!!!");
        }


    }
}
