using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformTour : MonoBehaviour
{
    public Transform[] pose; // Corrección: Transform[] para un array de posiciones
    public float speed;
    public int ID; // numeración de posiciones
    public int sum; // orientación de desplazamiento

    void Start()
    {
        transform.position = pose[0].position; // Corrección: uso de corchetes para acceder al array
    }

    void Update()
    {
        if (transform.position == pose[ID].position) // Corrección: posición está bien escrito
        {
            ID += sum;
        }

        if (ID == pose.Length - 1) // Comprobación para el último índice del array
        {
            sum = -1;
        }

        if (ID == 0) // Comprobación para el primer índice del array
        {
            sum = 1;
        }

        transform.position = Vector3.MoveTowards(transform.position, pose[ID].position, speed * Time.deltaTime); // Corrección: uso de corchetes para acceder al array
    }
}
