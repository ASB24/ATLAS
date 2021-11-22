using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    public Text ScoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString();
        InvokeRepeating("decreasePoints", 0.0f, 10.0f);
    }
    private void update()
    {
    }

    public void AddPoints(int valor)
    {
        score += valor;
    }

    void decreasePoints()
    {
        if (score > 0)
        {
            score -= 5;
            ScoreText.text = score.ToString();
        }
    }
}
