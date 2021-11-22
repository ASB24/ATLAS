using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    public asteroid asteroid;
    public bool stop = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAsteroid", spawnTime, spawnDelay);
    }

    public void spawnAsteroid()
    {
        Instantiate( asteroid, new Vector3(transform.position.x + randOffset(), transform.position.y, transform.position.z), transform.rotation );
        if (stop) CancelInvoke("spawnAsteroid");
    }

    private float randOffset()
    {
        return Random.Range(-8f,5f);
    }
}
