using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Carril : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carro"))
        {
            Debug.Log("SALISTE DEL CARRIL");
        }
    }
}
