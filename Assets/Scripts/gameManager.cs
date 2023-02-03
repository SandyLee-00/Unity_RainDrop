using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
  public GameObject rain;

  public static gameManager I;

  public GameObject panel;

  public Text scoreText;
  public Text timeText;

  int totalScore = 0;
  public float limit = 30.0f;

  private void Awake()
  {
    I = this;
  }

  void Start()
  {
    InvokeRepeating("makeRain", 0, 0.5f);
    initGame();
  }

  void Update()
  {
    limit -= Time.deltaTime;
    if (limit < 0)
    {
      limit = 0.0f;
      panel.SetActive(true);
      Time.timeScale = 0.0f;
    }
    timeText.text = limit.ToString("N0");
  }

  void initGame()
  {
    Time.timeScale = 1.0f;
    totalScore = 0;
    limit = 30.0f;
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

  public void retry()
  {
    SceneManager.LoadScene("MainScene");
  }
}
