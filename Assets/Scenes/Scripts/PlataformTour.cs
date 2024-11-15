using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformTour : MonoBehaviour
{
    public Transform[] pose; // Correcci�n: Transform[] para un array de posiciones
    public float speed;
    public int ID; // numeraci�n de posiciones
    public int sum; // orientaci�n de desplazamiento

    void Start()
    {
        transform.position = pose[0].position; // Correcci�n: uso de corchetes para acceder al array
    }

    void Update()
    {
        if (transform.position == pose[ID].position) // Correcci�n: posici�n est� bien escrito
        {
            ID += sum;
        }

        if (ID == pose.Length - 1) // Comprobaci�n para el �ltimo �ndice del array
        {
            sum = -1;
        }

        if (ID == 0) // Comprobaci�n para el primer �ndice del array
        {
            sum = 1;
        }

        transform.position = Vector3.MoveTowards(transform.position, pose[ID].position, speed * Time.deltaTime); // Correcci�n: uso de corchetes para acceder al array
    }
}
