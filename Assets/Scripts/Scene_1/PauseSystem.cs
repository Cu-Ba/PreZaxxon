using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu = null;
    bool isPaused = false;
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
            Time.timeScale = 0;
            pauseMenu.SetActive(isPaused);
        }
    }
}
