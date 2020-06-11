using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finish;
    

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string mins = ((int)t / 60).ToString();
        string secs = (t % 60).ToString("f2");
        timerText.text = mins + ":" + secs;
        if (secs == "20")
        {
            Debug.Log("time over");
            finnish();

        }
    }

    public void finnish()
    {
        finish = true;
        timerText.color = Color.yellow;
    }
}
