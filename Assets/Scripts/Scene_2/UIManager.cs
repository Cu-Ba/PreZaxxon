using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Sprite[] livesSprite;
    [SerializeField] private Image livesIMG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLive();
    }

    public void UpdateLive(int currentLives)
    {
        livesIMG.sprite = livesSprite[currentLives];
    }
}
