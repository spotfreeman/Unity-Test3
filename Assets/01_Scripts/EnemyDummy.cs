using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDummy : MonoBehaviour
{
    private bool hasBeenHit = false;
    public float recoilForce = 5f; // Ajusta la fuerza de retroceso según tus necesidades



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasBeenHit)
        {
            if (collision.gameObject.CompareTag("shoot"))
            {
                // Cambiar de color por un segundo y luego volver a la normalidad usando una corrutina
                StartCoroutine(ChangeColorAndApplyRecoil(Color.red, 1f, collision.transform.position));
            }
        }
    }

    IEnumerator ChangeColorAndApplyRecoil(Color newColor, float duration, Vector2 impactPosition)
    {
        // Cambiar de color
        GetComponent<SpriteRenderer>().color = newColor;

        // Calcular la dirección de retroceso
        Vector2 recoilDirection = transform.position - new Vector3(impactPosition.x, impactPosition.y, transform.position.z);
        recoilDirection.Normalize();

        // Aplicar fuerza de retroceso
        GetComponent<Rigidbody2D>().AddForce(recoilDirection * recoilForce, ForceMode2D.Impulse);

        // Esperar la duración
        yield return new WaitForSeconds(duration);

        // Restaurar el color original
        GetComponent<SpriteRenderer>().color = Color.white;

        // Establecer que ya ha sido impactado
        hasBeenHit = false;
    }


}
