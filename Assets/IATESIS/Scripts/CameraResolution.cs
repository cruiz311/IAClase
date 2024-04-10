using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    void Start()
    {
        // Obtén la referencia de la cámara principal
        Camera mainCamera = Camera.main;

        // Establece la resolución de la cámara
        mainCamera.targetDisplay = 0; // El número de la pantalla a la que está conectada la cámara (0 es la pantalla principal)
        mainCamera.allowHDR = true; // Activa el modo HDR si lo deseas
        mainCamera.allowMSAA = false; // Activa el anti-aliasing si lo deseas
        mainCamera.aspect = 16f / 9f; // Relación de aspecto (opcional)
        mainCamera.targetTexture = null; // Opcional: define una textura de destino si deseas renderizar la cámara en una textura
        mainCamera.depth = 1; // Opcional: establece la profundidad de la cámara
        mainCamera.renderingPath = RenderingPath.Forward; // Opcional: selecciona el método de renderizado (Forward o Deferred)
        mainCamera.pixelRect = new Rect(0, 0, 1920, 1080); // Establece la resolución de la cámara (1920x1080 en este caso)
    }
}
