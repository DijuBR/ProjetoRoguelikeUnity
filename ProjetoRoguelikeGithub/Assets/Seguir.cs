using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    private Transform playerPos;
    public float speed;

    private void Start()
    {
        playerPos = GameObject.FindWithTag("Player").transform;
    }
    private void Update()
    { 

        Vector2 pos = new Vector2(playerPos.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);
    }
}
