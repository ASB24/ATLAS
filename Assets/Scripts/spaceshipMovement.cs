using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public bulletMovement bullet;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spaceShipMovement()
    {
        rb.velocity = new Vector3(0f,3f, 0f);
    }
    public void Shoot()
    {
        Instantiate(bullet, new Vector3(transform.position.x-1.5f, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
