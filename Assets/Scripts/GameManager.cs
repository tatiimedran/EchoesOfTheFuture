using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public HUD hud;

    public int totalPoints { get; private set; }

    private int _life = 3;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Watch out! More than one GameManager on the scene.");
        }
    }

    public void pointsToAdd (int pointsToAdd)
    {
        totalPoints += pointsToAdd; //totalPoints = totalPoint + pointstoAdd
        hud.updatePoints(totalPoints);
    }

  

    public bool recoverLife()
    {
        if (_life == 3)
        {
            return false;
        }

        hud.activateLife(_life);
        _life += 1;
        return true;
    }
}
