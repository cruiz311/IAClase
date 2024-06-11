using System.Collections;
using UnityEngine;

public class RutaControl : MonoBehaviour
{
    public TipoPrueba tipoPrueba;
    public GameObject pruebaA;
    public GameObject pruebaB;

    private void Start()
    {
        tipoPrueba = GameManager.Instance.tipoPrueba;
        PruebaSeleccionada();
    }



    public void PruebaSeleccionada()
    {
        switch (tipoPrueba)
        {
            case TipoPrueba.TipoA:
                pruebaA.SetActive(true);
                break;

            case TipoPrueba.TipoB:
                pruebaB.SetActive(true);
                break;
        }

    }
}
