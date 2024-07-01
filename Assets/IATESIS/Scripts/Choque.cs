using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque:MonoBehaviour
{
    public DeteccionErrores deteccionErrores;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Carro"))
        {
            deteccionErrores.puntos -= 30;
            deteccionErrores.ActualizarMensaje("Haz chocado el vehículo, recibiras una penalizacion de 30 puntos, recuerda ver tus espejos para tener una mejor visualiación de tu entorno");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Carro"))
        {
            deteccionErrores.ActualizarMensaje("Mira bien tus espejos cuando estes al volante");
        }
    }
}
