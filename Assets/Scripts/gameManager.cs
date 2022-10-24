using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject rain;
    public static gameManager I;

    public GameObject panel;
    public Text scoreText;
    public Text timeText;

    public float limit = 30;

    int totalScore = 0;

    private void Awake()
    {
        I = this;
    }

    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);
    }

    void Update()
    {
        limit -= Time.deltaTime;
        if(limit < 0)
        {
            limit = 0.0f;
            panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
        timeText.text = limit.ToString("N2");
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }
    
}
