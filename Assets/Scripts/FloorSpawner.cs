using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FloorSpawner : MonoBehaviour
{
    public GameObject lastFloor;
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            buildFloor();
            
        }
    }

    public void buildFloor()
    {
        Vector3 direction;
        if(Random.Range(0,2)==0)
        {
            direction=Vector3.left;
        }
        else
        {
            direction=Vector3.forward;
        }
        lastFloor = Instantiate(lastFloor, lastFloor.transform.position + direction,
            lastFloor.transform.rotation);
    }
}
