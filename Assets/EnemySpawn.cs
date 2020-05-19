using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float time = 0.0f;
    public float interpolationPeriod = 1.0f;
    public GameObject enemyPrefab;
    public Vector2 spawnPointUp;
    public Vector2 spawnPointDown;
    public float check = 1.0f;
    // Update is called once per frame
    void Update()
    {
        spawnPointUp = new Vector2(Random.Range(-4.5f, 4.5f), Random.Range(2f, 4.5f));
        spawnPointDown = new Vector2(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, -2f));
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            if (check == 1)
            {
                GameObject enemyUp = Instantiate(enemyPrefab, spawnPointUp, Quaternion.identity);
                check = 0;
            }
            else if (check == 0)
            {
                GameObject enemyDown = Instantiate(enemyPrefab, spawnPointDown, Quaternion.identity);
                check = 1;
            }
        }
        
    }

}
