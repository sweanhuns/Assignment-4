using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speedEnemy = 2f;
    public GameObject player;
    public Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        target = new Vector2(player.transform.position.x, player.transform.position.y);
        float step = speedEnemy * Time.fixedDeltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
}
