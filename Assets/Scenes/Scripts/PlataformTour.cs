using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformTour : MonoBehaviour
{
    public Transform[] pose; 
    public float speed;
    public int ID; // NIM  posiciones
    public int sum; 

    void Start()
    {
        transform.position = pose[0].position; 
    }

    void Update()
    {
        if (transform.position == pose[ID].position)
        {
            ID += sum;
        }

        if (ID == pose.Length - 1)
        {
            sum = -1;
        }

        if (ID == 0)
        {
            sum = 1;
        }

        transform.position = Vector3.MoveTowards(transform.position, pose[ID].position, speed * Time.deltaTime);
    }
}
