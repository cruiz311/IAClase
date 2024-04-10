using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 2.0f; // Sensibilidad del movimiento de la cámara en el eje Y
    public float minYAngle = -80f; // Mínimo ángulo de rotación en el eje Y
    public float maxYAngle = 50f; // Máximo ángulo de rotación en el eje Y

    private float mouseX;

    void Update()
    {
        // Obtener el movimiento horizontal del mouse
        mouseX += Input.GetAxis("Mouse X") * sensitivity;

        // Limitar el ángulo de rotación vertical entre minYAngle y maxYAngle
        mouseX = Mathf.Clamp(mouseX, minYAngle, maxYAngle);

        // Rotar la cámara horizontalmente según el movimiento del mouse, dentro del rango especificado
        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
}
