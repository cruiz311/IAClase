using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreeringBehavior : MonoBehaviour
{
    public Transform target; // El objetivo hacia el que queremos dirigirnos

    // Método para el comportamiento de llegar (arrive)
    public void Arrive()
    {
        // Si no hay un objetivo, salimos del método
        if (target == null)
            return;

        // Calculamos la dirección hacia el objetivo
        Vector3 direction = target.position - transform.position;

        // Si estamos lo suficientemente cerca del objetivo, nos detenemos
        if (direction.magnitude < 0.1f)
        {
            // Detenemos el objeto
            // Esto podría ser el lugar donde ejecutes otras acciones cuando llegues al destino
            Debug.Log("Arrived at destination!");
            return;
        }

        // Normalizamos la dirección para obtener un vector de dirección unitario
        Vector3 desiredVelocity = direction.normalized;

        // Definimos una velocidad máxima
        float maxSpeed = 5f;

        // Multiplicamos la velocidad deseada por la velocidad máxima para obtener la velocidad deseada
        desiredVelocity *= maxSpeed;

        // Calculamos la fuerza de dirección, que es la diferencia entre la velocidad deseada y la velocidad actual
        Vector3 steering = desiredVelocity - GetComponent<Rigidbody>().velocity;

        // Aplicamos la fuerza de dirección al objeto
        GetComponent<Rigidbody>().velocity += steering * Time.deltaTime;

        // (Opcional) Rotamos el objeto para que mire en la dirección de movimiento
        transform.rotation = Quaternion.LookRotation(GetComponent<Rigidbody>().velocity);
    }
}
