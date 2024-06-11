using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    public Button button;
    public TipoPrueba prueba;

    private void Start()
    {

        button.onClick.AddListener(SelectPrueba);
    }
    public void SelectPrueba()
    {
        GameManager.Instance.tipoPrueba = prueba;
        SceneManager.LoadScene("TesisScena");
    }

}
