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
    }
    private void update(){
    }

    public void AddPoints(int valor) {
        score += valor;
    }
}
