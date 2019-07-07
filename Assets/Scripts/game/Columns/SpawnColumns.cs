using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColumns : MonoBehaviour
{

    public GameObject column;

    float nextSpawn = 0.0f;
    float spawnRate = 2.0f;
    float angle;
    float halfScreenHeight;
    float screenWidth;
    float randY;

    Quaternion spawnAngle;
    Vector2 whereToSpawn;
 
    // Start is called before the first frame updateŚ
    void Start()
    {
        halfScreenHeight = Screen.currentResolution.height/2;
        screenWidth = Screen.currentResolution.width/2 + 200;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = generateSpawnLocation();
            spawnAngle = generateSpawnAngle();
            Instantiate(column, whereToSpawn, spawnAngle);
        }
    }

    private Quaternion generateSpawnAngle()
    {
        angle =  Random.Range(-50f, 50f);
        return Quaternion.Euler(0, 0, (int)angle);
    }

    private Vector2 generateSpawnLocation()
    {
        randY = Random.Range(-halfScreenHeight, halfScreenHeight);
        return new Vector2(screenWidth, randY);
    }
}
