using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text display;
    
    // Start is called before the first frame update
    void Start()
    {
        display.text = string.Format("Score: {0:0.0}", Score.getScore()) + "\n" + string.Format("Highest Score: {0:0.0}", Score.getHighestScore());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
