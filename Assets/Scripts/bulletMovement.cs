using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletMovement : MonoBehaviour
{
    public ScoreManager scoreManager;
    public healthBar HealthBar;

    // Start is called before the first frame update
    private float speed = 10;
    void Start()
    {
        HealthBar = (healthBar)FindObjectOfType(typeof(healthBar));
        scoreManager = (ScoreManager)FindObjectOfType(typeof(ScoreManager));
        transform.Rotate(0f, 0f, 180f);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            scoreManager.AddPoints(10);
            scoreManager.ScoreText.text = scoreManager.score.ToString();
            HealthBar.SetHealth(scoreManager.score);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "boundary") {
            Destroy(gameObject);
        }
    }
}
