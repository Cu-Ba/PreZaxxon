using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get; private set;}

    public float Score {get; set;}

    private void Awake()
    {
        Instance = this; 
    }

    public void IncreaseScore(float amount)
    {
        Score += amount;
    }
}
