using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPathFollowing : MonoBehaviour
{
    ArriveBehavior arrive;
    PathFollowing path;
    // Start is called before the first frame update
    void Start()
    {
        arrive = GetComponent<ArriveBehavior>();
        path = GetComponent<PathFollowing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (path.currentPoint != null)
        {
            path.NextCurrentPointPath();
            arrive.target = path.currentPoint;
        }
    }
}

