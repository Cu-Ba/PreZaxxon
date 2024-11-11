using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    float score;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetFloat("PlayerScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        //OnTwentySeconds();
        PointsPerSeconds();
    }

    /*void OnTwentySeconds()
    {
        int timePassed = (int)Math.Round(Time.deltaTime);
        int division = timePassed % 2;
        if (division == 0){
            score += 10; 
        }
        Debug.Log("Time passed " + timePassed + " and the scroe is: " + score);
    }*/

    void PointsPerSeconds()
    {
        float points = 20f;
        float totalPoints = points * Time.deltaTime;
        ScoreManager.Instance.Score += (int)Math.Round(totalPoints);
        PlayerPrefs.SetFloat("PlayerScore", ScoreManager.Instance.Score);
        //Debug.Log("Score: " + ScoreManager.Instance.Score);

    }
}
