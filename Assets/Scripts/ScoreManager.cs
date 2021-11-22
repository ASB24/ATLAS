using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public healthBar HealthBar;
    public Text ScoreText;
    public int score;
    public AudioClip endMusic;
    private AudioSource audio;
    public GameObject popup;

    // Start is called before the first frame update
    void Start()
    {
        popup.SetActive(false); 
        audio = GetComponent<AudioSource>();
        score = 10;
        ScoreText.text = score.ToString();
        InvokeRepeating("decreasePoints", 0.0f, 10.0f);
    }

    public void AddPoints(int valor)
    {
        score += valor;
    }

    void decreasePoints()
    {
        if (score > 5)
        {
            score -= 5;
        }
        else if(score <= 5)
        {
            score = 0;
        }
        ScoreText.text = score.ToString();
        HealthBar.SetHealth(score);
    }

    public void endGame()
    {
        Time.timeScale = 0;
        audio.Stop();
        audio.clip = endMusic;
        audio.Play();
        popup.SetActive(true);
    }
}
