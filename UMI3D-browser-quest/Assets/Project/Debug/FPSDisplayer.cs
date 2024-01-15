using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSDisplayer : MonoBehaviour
{
   public UnityEngine.UI.Text displayText;

    public float refreshRate = 0.2f;

    double timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (Time.unscaledTime > timer + refreshRate)
        {
            timer = Time.unscaledTime;
            displayText.text = "FPS " + ((int)(1f / Time.unscaledDeltaTime)).ToString();
        }
        
    }
}
