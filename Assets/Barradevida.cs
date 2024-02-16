using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barradevida : MonoBehaviour
{
    private Slider slider;
    [SerializeField] private float maxima = GameManager.Instance.maxHealth;
    [SerializeField] private float actual = GameManager.Instance.health;
    // Start is called before the first frame update
    private void Start()
    {
        slider = GetComponent<Slider>();
        
    }

    public void CambiarVidaMaxima(float maxima)
    {
        slider.maxValue = maxima;
    }

    public void CambiarVidaActual(float actual)
    {
        slider.value = actual;
    }

    public void IniciarBarra(float cantidadVida)
    {
        CambiarVidaMaxima(maxima);
        CambiarVidaActual(actual);
    }


}
