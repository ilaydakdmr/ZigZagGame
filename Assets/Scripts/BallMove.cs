using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BallMove : MonoBehaviour
{
    private Vector3 _direction;
    public float speed;
    public FloorSpawner floorspawnerscript;
    public static bool is_falling;
    public float addspeed;
    void Start()
    {
        _direction = Vector3.forward;
        is_falling = false;
    }


    void Update()
    {
        if(transform.position.y<=0.5f)
        {
            is_falling = true;
        }
        if (is_falling== true)
        {
            Debug.Log("Ifell");
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (_direction.x == 0)
            {
                _direction = Vector3.left;
            }
            else
            {
                _direction = Vector3.forward;
            }

            speed=speed + addspeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
        {
            Vector3 move = _direction * Time.deltaTime * speed;
            transform.position += move;
        }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            floorspawnerscript.buildFloor();
            StartCoroutine(DeleteFloor(collision.gameObject));
        }
    }

    IEnumerator DeleteFloor(GameObject wipefloor)
    {
        yield return new WaitForSeconds(3f);
        Destroy(wipefloor);
    }
    
}
