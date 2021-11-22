using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Popup : MonoBehaviour
{
    [SerializeField] Text TitleUIText;
    [SerializeField] Button play_again;
    [SerializeField] Button stop_playing;
    public ScoreManager scoremanager;

    // Start is called before the first frame update
    void Start()
    {
        if (scoremanager.score >= 500)
        {
            TitleUIText.text = "Has ganado :)";
        }
        else {
            TitleUIText.text = "Has perdido :(";
        }
    }

    public void new_game() {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void menu_return() {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
