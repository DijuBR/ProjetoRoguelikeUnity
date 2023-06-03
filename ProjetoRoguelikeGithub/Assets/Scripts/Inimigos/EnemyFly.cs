using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFly : MonoBehaviour
{
    public float speed;
    private GameObject player;
    public bool perseguir = false;
    public Transform startingPoint;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
            return;
        if (perseguir == true)
            Perseguir();
        else
            ReturnStartPosition();
        Flip();
    }
    private void Perseguir()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, player.transform.position) <= 0.5f)
        {
            //change speed, shoot, animation
        }
        else
        {
            //reset variables
        }
    }
    private void Flip()
    {
        if (transform.position.x > player.transform.position.x)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else
            transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void ReturnStartPosition()
    {
        transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);
    }
}
