using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Posicion : MonoBehaviour
{
    public Ruta ruta;
    public GameObject avisoObject; // El GameObject que se activará después de 5 segundos
    public bool EstoyEnSemaforo = false; // Nuevo booleano para controlar el tiempo
    private bool hasCollided = false;
    private float timer = 0f;
    private bool avisoActivated = false;
    private float waitTime;

    private void Start()
    {
        avisoObject.SetActive(false); // Asegúrate de que el GameObject esté desactivado al inicio
        waitTime = EstoyEnSemaforo ? 30f : 150f; // Asigna el tiempo de espera basado en EstoyEnSemaforo
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carro"))
        {
            hasCollided = true;
            ruta.CambiarAlineacion();
        }
    }

    private void Update()
    {
        if (!hasCollided)
        {
            timer += Time.deltaTime;

            if (timer >= waitTime && !avisoActivated)
            {
                avisoObject.SetActive(true);
                Time.timeScale = 0;
                avisoActivated = true;
                StartCoroutine(ChangeSceneAfterDelay(3f));
            }
        }
    }

    private IEnumerator ChangeSceneAfterDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay); // Usa WaitForSecondsRealtime ya que timeScale está en 0
        SceneManager.LoadScene("ChooseRuta");
    }
}
