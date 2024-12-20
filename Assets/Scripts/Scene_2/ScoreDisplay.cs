using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    float score;
    public Text ScoreText; 
    float transitionSpeed = 100f;

    float displayScore;

    void Start(){
        score = ScoreManager.Instance.Score;
    }

    public void Update()
    {
        score = ScoreManager.Instance.Score;
        displayScore = Mathf.MoveTowards(displayScore, score, transitionSpeed * Time.deltaTime);
        UpdateScoreDisplay();
        Debug.Log(score);
    }
    public void IncreaseScore(float amount)
    {
        score += amount;
        UpdateScoreDisplay();

    }

    public void UpdateScoreDisplay()
    {
        ScoreText.text = string.Format("Score: {0:00000}", displayScore);
    }
}

