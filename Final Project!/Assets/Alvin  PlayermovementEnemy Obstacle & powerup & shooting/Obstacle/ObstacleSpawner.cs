using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float TimeBetweenSpawn;
    public float SpawnTime;





    // Start is called before the first frame update
    void Start()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }

    }

    // Update is called once per frame
    void Spawn()
    {
        float X = Random.Range (minX, maxY);
        float Y = Random.Range (minY, maxX);

        Instantiate(Obstacle, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
