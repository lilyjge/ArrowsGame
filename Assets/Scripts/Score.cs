using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float score = 0f;

    public static float highestScore = 0f;

    public Text scoreDisplay;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score += Time.deltaTime;

        scoreDisplay.text = string.Format("Score: {0:0.0}", score);
    }

    public static float getScore()
    {
        return score;
    }

    public static float getHighestScore()
    {
        if(score > highestScore)
        {
            highestScore = score;
        }
        return highestScore;
    }

    public static void resetScore()
    {
        score = 0;
    }


    public static float getHigh()
    {
        return highestScore;
    }
}
