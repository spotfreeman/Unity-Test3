using UnityEngine;
using UnityEngine.UI;

public class WeaponMenu : MonoBehaviour
{
    public GameObject imagenUI;

    private void Start()
    {
        // Asegúrate de que la imagen UI esté desactivada al inicio.
        if (imagenUI != null)
        {
            imagenUI.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el jugador ha tocado el objeto interactuable.
        if (other.CompareTag("Player"))
        {
            // Activa la imagen UI al tocar el objeto.
            if (imagenUI != null)
            {
                imagenUI.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        imagenUI.SetActive(false);
    }

    // Puedes agregar más lógica para desactivar la imagen cuando el jugador se aleje del objeto.
}

