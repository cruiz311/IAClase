using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruta : MonoBehaviour
{
    public Transform initPosition;
    public GameObject carro;
    public List<GameObject> alineaciones;
    public int currentAlineacionIndex = 0;
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
            alineaciones[currentAlineacionIndex].SetActive(true);
        }
    }

    public void CambiarAlineacion()
    {
        alineaciones[currentAlineacionIndex].SetActive(false);
        currentAlineacionIndex++;

        if (currentAlineacionIndex >= alineaciones.Count)
        {
            // cambiar de scena
            return;
        }

        alineaciones[currentAlineacionIndex].SetActive(true);
    }

}
