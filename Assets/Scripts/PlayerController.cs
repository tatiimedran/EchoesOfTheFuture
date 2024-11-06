using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalMov;

    void Start()
    {
        horizontalMov = 0;
    }

    void Update()
    {
        horizontalMov = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(horizontalMov * speed * Time.deltaTime, 0, 0));

    }
}
