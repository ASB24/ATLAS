using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public Sprite[] asteroids;
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    public bool isSmall = false;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
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
        int index = Random.Range(0,sprites.Length-1);
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
            Destroy(gameObject);
        }
    }
}
