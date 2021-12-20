using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int score=0;
    public int highScoree;

    public Text scoreText;
    public Text highScore;

    
    
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = "En Yüksek Skor=" + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
       if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);          
        }
    }

    public void Score()
    {
        score++;
        scoreText.text = score.ToString();
    }
   
    
}
