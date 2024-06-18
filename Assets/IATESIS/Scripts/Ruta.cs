using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruta : MonoBehaviour
{
    public Transform initPosition;
    public GameObject carro;
    public List<GameObject> alineaciones;
    private void Start()
    {
        GameObject nuevoCarro = Instantiate(carro, initPosition.position, carro.transform.rotation);
        Init();
    }


    public void Init()
    {
        foreach (GameObject t in alineaciones)
        {
            t.SetActive(false);
            alineaciones[0].SetActive(true);
        }
    }
}
