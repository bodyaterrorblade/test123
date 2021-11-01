using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public GameManager ga;
    public int score = 0;
    public GameObject ScoreText;
    

    public void Coin()
    {
        score++;
        ScoreText.GetComponent<Text>().text = "Score" + score.ToString();
       
    }
}
