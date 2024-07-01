using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeteccionErrores:MonoBehaviour
{
    public int puntos;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI mensaje;


    public int RestarPuntosPorSalirDeRuta;
    private void Update()
    {
        puntuacion.text = puntos.ToString();
        VerificarPuntos();
    }
    public void ActualizarMensaje(string mensajeActualizar)
    {
        mensaje.text = mensajeActualizar;
    }
    public void VerificarPuntos()
    {
        if(RestarPuntosPorSalirDeRuta == 3)
        {
            puntos-=5;
            RestarPuntosPorSalirDeRuta = 0;
        }
    }
}
