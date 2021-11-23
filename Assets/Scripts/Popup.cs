using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Popup : MonoBehaviour
{
    public Text TitleUIText;
    public Button play_again;
    public Button stop_playing;
    public ScoreManager scoremanager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void new_game() {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void menu_return() {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void setActive(bool value)
    {
        if (value)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
