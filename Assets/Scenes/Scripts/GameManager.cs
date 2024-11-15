using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    public int totalPoints { get { return _totalPoints; } } 
    private int _totalPoints;

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

    public void pointsToAdd(int pointsToAdd)
    {
        _totalPoints += pointsToAdd; //totalPoints = totalPoint + pointstoAdd
    }

    public bool recoverLife()
    {
        if (_life == 3)
        {
            return false;
        }

        _life += 1;
        return true;
    }


}
