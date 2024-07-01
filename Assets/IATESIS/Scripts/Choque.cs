using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque:MonoBehaviour
{
    public DeteccionErrores deteccionErrores;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carro"))
        {
            deteccionErrores.puntos -= 30;
            deteccionErrores.ActualizarMensaje("Haz chocado el veh�culo, recibiras una penalizacion de 30 puntos, recuerda ver tus espejos para tener una mejor visualiaci�n de tu entorno");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Carro"))
        {
            deteccionErrores.ActualizarMensaje("Mantente siempre en tu carril");
        }
    }
}
