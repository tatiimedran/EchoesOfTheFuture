using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TMP_Text textScore; // Corrige el tipo aquí
    public GameObject gameOverPanel; // Cambia a GameObject
    public TMP_Text gameOverText; // Texto que dice "Game Over"
    public TMP_Text restartText;

    public void ShowGameOver()
    {
        
       gameOverPanel.SetActive(true);
        textScore.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true); // Activa el texto "Game Over" restartText.gameObject.SetActive(true); // Activa el texto "Reiniciar"
        textScore.text = (( "Score: ")+ FindObjectOfType<PlayerController>().score).ToString(); // Asegúrate de tener un campo score en PlayerController
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
