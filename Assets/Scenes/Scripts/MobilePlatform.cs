using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatform : MonoBehaviour
{
    public GameObject objectToMove; //obj a mover

    public Transform StartPoint;
    public Transform EndPoint;

    public float speed;

    private Vector3 _moveTowards; //mover hacia

    void Start ()
    {
        _moveTowards= EndPoint.position;
    }

    void Update()
    {
        objectToMove.transform.position = Vector3. MoveTowards (objectToMove. transform.position, _moveTowards, speed * Time.deltaTime);    

        if (objectToMove. transform.position == EndPoint. position)
        {
            _moveTowards = StartPoint.position;
        }


        if (objectToMove.transform.position == StartPoint.position)
        {
            _moveTowards = EndPoint.position;
        }


    }

}
