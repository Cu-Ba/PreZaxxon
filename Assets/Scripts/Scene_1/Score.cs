using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("SCORE: " + score);
        OnTwentySeconds();
    }

    void OnTwentySeconds()
    {
        int timePassed = (int)Math.Round(Time.deltaTime);
        int division = timePassed % 2;
        if (division == 0){
            score += 10; 
        }
    }
}
