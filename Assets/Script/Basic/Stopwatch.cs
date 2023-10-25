using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Stopwatch : MonoBehaviour
{
    float currentTime;
    public Text currentTimetext;
    static float timerCopy;

    // Start is called before the first frame update
    void Awake()
    {
        currentTime = 0;
        currentTime = timerCopy;
        currentTimetext = GetComponent<Text>();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        timerCopy = currentTime;
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimetext.text = time.ToString(@"mm\:ss");
        
    }
}
