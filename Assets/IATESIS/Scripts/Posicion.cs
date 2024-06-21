using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    public Ruta ruta;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carro"))
        {
            ruta.CambiarAlineacion();
        }
    }
}
