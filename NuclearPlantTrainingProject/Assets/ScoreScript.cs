using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    float timer = 120;
    int minutes;
    int seconds;
    public Text display;
    public GameObject GreenLight1;
    public GameObject RedLight1;
    public GameObject GreenLight2;
    public GameObject RedLight2;
    public GameObject GreenLight3;
    public GameObject RedLight3;
    public GameObject ScriptToStop;
    public GameObject Startable;
    float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        display.text = "\nScore: 0\nTime: 2:00";
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0 && !Startable.activeSelf)
        {
            if (!RedLight1.activeSelf && !RedLight2.activeSelf && !RedLight3.activeSelf)
            {
                if (GreenLight1.activeSelf)
                    score += Time.deltaTime;
                if (GreenLight2.activeSelf)
                    score += Time.deltaTime;
                if (GreenLight3.activeSelf)
                    score += Time.deltaTime;
            }
            minutes = ((int)timer) / 60;
            seconds = ((int)timer) % 60;
            display.text = "\nScore: " + (int)score + "\nTime: " + minutes + ":" + seconds.ToString("00");
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 120;
            score = 0;
            Startable.SetActive(true);
            ScriptToStop.SetActive(false);
        }
    }
}
