using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    void Start()
    {
        // Obt�n la referencia de la c�mara principal
        Camera mainCamera = Camera.main;

        // Establece la resoluci�n de la c�mara
        mainCamera.targetDisplay = 0; // El n�mero de la pantalla a la que est� conectada la c�mara (0 es la pantalla principal)
        mainCamera.allowHDR = true; // Activa el modo HDR si lo deseas
        mainCamera.allowMSAA = false; // Activa el anti-aliasing si lo deseas
        mainCamera.aspect = 16f / 9f; // Relaci�n de aspecto (opcional)
        mainCamera.targetTexture = null; // Opcional: define una textura de destino si deseas renderizar la c�mara en una textura
        mainCamera.depth = 1; // Opcional: establece la profundidad de la c�mara
        mainCamera.renderingPath = RenderingPath.Forward; // Opcional: selecciona el m�todo de renderizado (Forward o Deferred)
        mainCamera.pixelRect = new Rect(0, 0, 1920, 1080); // Establece la resoluci�n de la c�mara (1920x1080 en este caso)
    }
}
