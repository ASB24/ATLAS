using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public Sprite[] asteroids;
    private SpriteRenderer sr;
    private AudioSource audio;
    private Rigidbody2D rb;
    private BoxCollider2D cd;
    public bool isSmall = false;
    public ScoreManager scoreManager;
    public healthBar HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        HealthBar = (healthBar)FindObjectOfType(typeof(healthBar));
        scoreManager = (ScoreManager)FindObjectOfType(typeof(ScoreManager));
        audio = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<BoxCollider2D>();
        sr.sprite = randSprite( asteroids );
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 6.0f * 40.0f * Time.deltaTime);
        if (isSmall) rb.gravityScale = -0.6f;
        else rb.gravityScale = -0.4f;
    }

    Sprite randSprite( Sprite[] sprites)
    {
        int index = Random.Range(0,sprites.Length);
        Debug.Log("Asteroide: " + sprites[index].name);
        if (index == 2) isSmall = true;
        return sprites[index];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boundary")
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "bullet")
        {
            if(isSmall) scoreManager.AddPoints(10);
            else scoreManager.AddPoints(1);
            scoreManager.ScoreText.text = scoreManager.score.ToString();
            HealthBar.SetHealth(scoreManager.score);
            StartCoroutine(explosionSound());
            cd.enabled = false;
            sr.enabled = false;
        }
    }

    private IEnumerator explosionSound()
    {
        audio.Play();
        yield return new WaitWhile(() => audio.isPlaying);
    }
}
