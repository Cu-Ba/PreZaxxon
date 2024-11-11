using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Sprite[] livesSprite;
    [SerializeField] private Image livesIMG;

    [SerializeField] GameObject Player;

    PlayerManager playerManager;
    int health;
    // Start is called before the first frame update

    IEnumerator WaitForScript()
    {
        yield return new WaitForSeconds (1f);
        Player.GetComponent<PlayerManager>();
        int vida = playerManager.health;
        health = vida;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLive(health);
    }

    public void UpdateLive(int currentLives)
    {
        livesIMG.sprite = livesSprite[currentLives];
    }
}
