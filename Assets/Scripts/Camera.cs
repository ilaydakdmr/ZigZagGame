using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform ballposition;
    private Vector3 difference;
    void Start()
    {
        difference = transform.position - ballposition.position;
    }

    
    void Update()
    {
        if (BallMove.is_falling == false)
        {
            transform.position = ballposition.position + difference;
        }
    }
}
