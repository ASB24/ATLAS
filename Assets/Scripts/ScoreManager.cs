using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    public Text ScoreText;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString() + " points";
    }

    public void AddPoints() {
        score += 1;
        ScoreText.text = score.ToString() + " points";
    }
}
