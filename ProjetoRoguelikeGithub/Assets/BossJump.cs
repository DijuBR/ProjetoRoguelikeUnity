using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossJump : StateMachineBehaviour
{
    [Header("Refs")]
    private Transform posTop;
    private Transform playerPos;
    private Rigidbody2D rb;

    [Header("Variaveis")]
    private float speed = 0.7f;
    private float queda = 2f;
    public float tempoMin, tempoMax, timer;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        posTop = GameObject.Find("BossTop").transform;
        playerPos = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rb = animator.GetComponent<Rigidbody2D>();
        timer = Random.Range(tempoMin, tempoMax);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(timer <= 0)
        {
            rb.AddForce(Vector2.down * queda);
        }
        else
        {
            timer -= Time.deltaTime;
        }
        Stomp(animator);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    void Stomp(Animator anim)
    {
        anim.transform.position = posTop.position;
    }
}
