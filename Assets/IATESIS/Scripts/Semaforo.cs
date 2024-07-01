using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum semaforo
{
    rojo,
    amber,
    verde
}
public class Semaforo : MonoBehaviour
{

    public DeteccionErrores deteccionErrores;
    public semaforo colorSemaforo;
    public GameObject redLight;
    public GameObject amberLight;
    public GameObject greenLight;

    public float redDuration = 5.0f;
    public float amberDuration = 2.0f;
    public float greenDuration = 5.0f;

    private IEnumerator Start()
    {
        while (true)
        {
            // Red light
            colorSemaforo = semaforo.rojo;
            SetLight(redLight, true);
            SetLight(amberLight, false);
            SetLight(greenLight, false);
            yield return new WaitForSeconds(redDuration);

            // Green light
            colorSemaforo = semaforo.verde;
            SetLight(redLight, false);
            SetLight(amberLight, false);
            SetLight(greenLight, true);
            yield return new WaitForSeconds(greenDuration);

            // Amber light
            colorSemaforo = semaforo.amber;
            SetLight(redLight, false);
            SetLight(amberLight, true);
            SetLight(greenLight, false);
            yield return new WaitForSeconds(amberDuration);
        }
    }

    private void SetLight(GameObject light, bool isActive)
    {
        light.SetActive(isActive);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Carro")&&colorSemaforo == semaforo.rojo)
        {
            deteccionErrores.puntos -= 30;
            deteccionErrores.ActualizarMensaje("Respeta los semaforos, es una falta grave");
        }
    }
}
