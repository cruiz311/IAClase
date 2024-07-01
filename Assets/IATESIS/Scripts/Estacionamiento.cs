using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estacionamiento : MonoBehaviour
{
    public DeteccionErrores deteccionErrores;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Carro"))
        {
            deteccionErrores.puntos -= 15;
            deteccionErrores.ActualizarMensaje("Haz chocado el vehículo a la hora de poder estacionar, se te sancionara con 15 puntos");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Carro"))
        {
            deteccionErrores.ActualizarMensaje("Coloca bien tus direccionales y mira tus espejos para estacionar mejor");
        }
    }
}
