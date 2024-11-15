using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //public TMP_Text textScore; 
    public GameObject gameOverPanel; 
    public TMP_Text gameOverText; // Texto Game Over
    public TMP_Text restartText;

    public void ShowGameOver()
    {
        
       gameOverPanel.SetActive(true);
        //textScore.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true); // Activa  Game Over" 
        //textScore.text = (( "Score: ")+ FindObjectOfType<PlayerController>().score).ToString(); 
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
