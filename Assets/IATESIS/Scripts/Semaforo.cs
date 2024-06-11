using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
{
    public GameObject redLight;
    public GameObject amberLight;
    public GameObject greenLight;

    public float redDuration = 5.0f; // Duration of red light
    public float amberDuration = 2.0f; // Duration of amber light
    public float greenDuration = 5.0f; // Duration of green light

    private IEnumerator Start()
    {
        while (true)
        {
            // Red light
            SetLight(redLight, true);
            SetLight(amberLight, false);
            SetLight(greenLight, false);
            yield return new WaitForSeconds(redDuration);

            // Green light
            SetLight(redLight, false);
            SetLight(amberLight, false);
            SetLight(greenLight, true);
            yield return new WaitForSeconds(greenDuration);

            // Amber light
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
}
