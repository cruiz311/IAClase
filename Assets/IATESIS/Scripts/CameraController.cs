using TMPro.EditorUtilities;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject focus;

    public float distance = 5f;
    public float height = 2f;
    public float dampening = 1f;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, focus.transform.position, Time.deltaTime);
    }
}
