using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMov : MonoBehaviour
{

    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.pointsToAdd(value);
            Destroy(this.gameObject);
        }
    }

}
