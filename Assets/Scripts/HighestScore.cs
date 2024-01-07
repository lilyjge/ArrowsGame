using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{
    public Text highS;
    
    // Start is called before the first frame update
    void Start()
    {
        float blah = Score.getHigh();
        highS.text = string.Format("Highest Score: {0:0.0}", blah);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
