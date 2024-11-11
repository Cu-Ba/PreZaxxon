using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class RenderScore : MonoBehaviour
{
    float score;
    public Text ScoreText; 
    float transitionSpeed = 100f;

    float displayScore;

    void Start()
    {
        score = ScoreManager.Instance.Score;
    }

    public void Update()
    {
        score = ScoreManager.Instance.Score;
        displayScore = Mathf.MoveTowards(displayScore, score, transitionSpeed * Time.deltaTime);
        UpdateScoreDisplay();
        Debug.Log(score);
    }

    public void UpdateScoreDisplay()
    {
        score = PlayerPrefs.GetFloat("PlayerScore");
        ScoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        else {
        Invoke("GoToMain", 5);
        }
    }


    void GoToMain()
    {
        SceneManager.LoadScene(0);
    }
}
