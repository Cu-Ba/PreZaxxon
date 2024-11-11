using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel = null;

    bool quitGame;


    // Update is called once per frame
    public void Update()
    {
        
    }

    public void LaunchGameOver()
    {
        Time.timeScale = 0f;
        quitGame = !quitGame;
        gameOverPanel.SetActive(quitGame);
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        PlayerPrefs.DeleteKey("PlayerScore");
    }

    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    
}
