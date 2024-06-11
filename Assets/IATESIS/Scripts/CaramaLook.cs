using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaramaLook : MonoBehaviour
{
    public float velocidadRotacion = 3.0f;

    void Update()
    {
        // Obtener el movimiento del mouse
        float movimientoHorizontal = Input.GetAxis("Mouse X") * velocidadRotacion;

        // Rotar la cámara en función del movimiento del mouse
        transform.Rotate(0, movimientoHorizontal, 0);

        // Restringir la rotación vertical entre -90 y 90 grados
        Vector3 rotacionActual = transform.localRotation.eulerAngles;
        rotacionActual.x = Mathf.Clamp(rotacionActual.x, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotacionActual);
    }
}
