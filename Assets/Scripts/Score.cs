using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public Text highScoreText;

    private void UpdateDistanceRan()
    {
        scoreText.text = player.position.z.ToString("0") + "m";
    }

    public void UpdateHighScore()
    {
        
        if ((int)player.position.z > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", (int)player.position.z);
            highScoreText.text = player.position.z.ToString("0") + "m";
        }
    }

    void Update()
    {
        UpdateDistanceRan();
    }
    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString() + "m";
    }
}
