using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    private void LateUpdate()
    {
        Vector3 position = transform.position;
        position.x = Player.transform.position.x;
        transform.position = position;
    }

}
