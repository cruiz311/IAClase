using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Carril : MonoBehaviour
{
    public DeteccionErrores deteccionErrores;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carro"))
        {
            deteccionErrores.RestarPuntosPorSalirDeRuta++;
            if(deteccionErrores.RestarPuntosPorSalirDeRuta > 2)
            {
                deteccionErrores.ActualizarMensaje("Saliste de tu carril, se te aplicara una sanción de 5 puntos, recuerda mirar tus espejos para orientar tu carril");
            }
            else
            {
                deteccionErrores.ActualizarMensaje("Saliste de tu carril, regresa o recibiras una penalizacion, Advertencia Nro:" + deteccionErrores.RestarPuntosPorSalirDeRuta.ToString());
            }
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
