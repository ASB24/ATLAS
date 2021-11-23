using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public healthBar HealthBar;
    public Text ScoreText;
    public int score;
    public AudioClip loseMusic;
    public AudioClip winMusic;
    private AudioSource audio;
    public Popup popup;
    private bool stopUpdate;

    // Start is called before the first frame update
    void Start()
    {
        stopUpdate = false;
        popup.setActive(false); 
        audio = GetComponent<AudioSource>();
        score = 1;
        ScoreText.text = score.ToString();
        InvokeRepeating("decreasePoints", 10.0f, 10.0f);
    }

    private void Update()
    {
        if (score >= 50 || score == 0)//For testing 
        {
            if (!stopUpdate)
            {
                endGame();
                stopUpdate = true;
            }
        }
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
        if (score >= 50)
        {
            popup.TitleUIText.text = "Has ganado :)";
            audio.clip = winMusic;
        }
        else
        {
            popup.TitleUIText.text = "Has perdido :(";
            audio.clip = loseMusic;
        }
        Time.timeScale = 0;
        audio.Stop();
        audio.Play();
        popup.setActive(true);
    }
}
