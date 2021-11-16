using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public AudioSource startSound;
    public AudioSource exitSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        StartCoroutine(start_game());
    }

    IEnumerator start_game()
    {
        startSound.Play();
        yield return new WaitWhile(() => startSound.isPlaying);
        SceneManager.LoadScene(1);
    }

    public void closeGame()
    {
        StartCoroutine(close_game());
    }

    IEnumerator close_game()
    {
        exitSound.Play();
        yield return new WaitWhile(() => exitSound.isPlaying);
        Application.Quit();
    }
}
