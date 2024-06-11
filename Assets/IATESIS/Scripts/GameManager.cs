using UnityEngine;

public enum TipoPrueba
{
    TipoA,
    TipoB
}
public class GameManager : MonoBehaviour
{
    // Instancia estática del GameManager
    private static GameManager instance;
    public TipoPrueba tipoPrueba;

    // Propiedad para acceder a la instancia del GameManager
    public static GameManager Instance
    {
        get
        {
            // Si la instancia no existe, la crea
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                // Si no hay GameManager en la escena, crea un GameObject y adjunta el GameManager
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("GameManager");
                    instance = singletonObject.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    // Código adicional del GameManager

    void Awake()
    {
        // Asegurarse de que solo haya una instancia del GameManager en la escena
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Mantener el GameManager cuando cambia de escena
        }
        else
        {
            Destroy(gameObject); // Destruir duplicados
        }
    }

    void Start()
    {
        // Aquí puedes realizar tareas de inicialización adicionales
    }

}
