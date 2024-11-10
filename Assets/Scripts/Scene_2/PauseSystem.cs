using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu = null;
    [SerializeField] GameObject exitPanel = null;
    bool isPaused;
    bool wantToExit;
    public bool GetIsPaused() { return isPaused; }
    // Update is called once per frame
    void Update()
    {
        PlayerPause();
    }

    void PlayerPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            pauseMenu.SetActive(isPaused);
            
        }
    }

    public void ContinuePlaying() 
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        pauseMenu.SetActive(isPaused);
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void ToggleConfirmation()
    {
        wantToExit = !wantToExit;
        exitPanel.SetActive(wantToExit);
    }
}
