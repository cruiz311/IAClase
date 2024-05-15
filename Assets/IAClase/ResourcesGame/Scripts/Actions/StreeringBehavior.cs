using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreeringBehavior : MonoBehaviour
{
    public Transform target; // El objetivo hacia el que queremos dirigirnos

    // M�todo para el comportamiento de llegar (arrive)
    public void Arrive()
    {
        // Si no hay un objetivo, salimos del m�todo
        if (target == null)
            return;

        // Calculamos la direcci�n hacia el objetivo
        Vector3 direction = target.position - transform.position;

        // Si estamos lo suficientemente cerca del objetivo, nos detenemos
        if (direction.magnitude < 0.1f)
        {
            // Detenemos el objeto
            // Esto podr�a ser el lugar donde ejecutes otras acciones cuando llegues al destino
            Debug.Log("Arrived at destination!");
            return;
        }

        // Normalizamos la direcci�n para obtener un vector de direcci�n unitario
        Vector3 desiredVelocity = direction.normalized;

        // Definimos una velocidad m�xima
        float maxSpeed = 5f;

        // Multiplicamos la velocidad deseada por la velocidad m�xima para obtener la velocidad deseada
        desiredVelocity *= maxSpeed;

        // Calculamos la fuerza de direcci�n, que es la diferencia entre la velocidad deseada y la velocidad actual
        Vector3 steering = desiredVelocity - GetComponent<Rigidbody>().velocity;

        // Aplicamos la fuerza de direcci�n al objeto
        GetComponent<Rigidbody>().velocity += steering * Time.deltaTime;

        // (Opcional) Rotamos el objeto para que mire en la direcci�n de movimiento
        transform.rotation = Quaternion.LookRotation(GetComponent<Rigidbody>().velocity);
    }
}
