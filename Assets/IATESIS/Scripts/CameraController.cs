using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 2.0f; // Sensibilidad del movimiento de la c�mara en el eje Y
    public float minYAngle = -80f; // M�nimo �ngulo de rotaci�n en el eje Y
    public float maxYAngle = 50f; // M�ximo �ngulo de rotaci�n en el eje Y

    private float mouseX;

    void Update()
    {
        // Obtener el movimiento horizontal del mouse
        mouseX += Input.GetAxis("Mouse X") * sensitivity;

        // Limitar el �ngulo de rotaci�n vertical entre minYAngle y maxYAngle
        mouseX = Mathf.Clamp(mouseX, minYAngle, maxYAngle);

        // Rotar la c�mara horizontalmente seg�n el movimiento del mouse, dentro del rango especificado
        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
}
