using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public GameManager GameManager;
    public TextMeshProUGUI points;
    public GameObject[] life;

    void Update()
    {

        if (GameManager.Instance != null)
        {
            points.text = GameManager.Instance.totalPoints.ToString();
        }
        else
        {
            Debug.LogError("GameManager.Instance es null en HUD.Update()");
        }
    }

    public void updatePoints(int totalPoints)
    {
        points.text = totalPoints.ToString();
    }

    public void disableLife(int index)
    {
        life [index].SetActive(false);
    }

    public void activateLife(int index)
    {
        life [index].SetActive(true);
    }
}
