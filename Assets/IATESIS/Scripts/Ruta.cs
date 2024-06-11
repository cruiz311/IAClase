using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruta : MonoBehaviour
{
    public Transform initPosition;
    public GameObject carro;

    private void Start()
    {
        GameObject nuevoCarro = Instantiate(carro, initPosition.position, carro.transform.rotation);

    }
}
