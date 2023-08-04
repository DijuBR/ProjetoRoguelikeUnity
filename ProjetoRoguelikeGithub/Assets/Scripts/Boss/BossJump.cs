using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossJump : StateMachineBehaviour
{
    ControladorAudio audioManager;
    
    [Header("Refs")]
    private Transform posTop;
    private Transform playerPos;
    private Rigidbody2D rb;

    [Header("Variaveis")]
    private float speed = 0.7f;
    private float queda = 2f;
    [Header("Timer")]
    public float tempoMin, tempoMax, timer;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
        posTop = GameObject.Find("BossTop").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        timer = tempoMax;

        Destroy(GameObject.FindWithTag("BossTiro"));
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        if(timer <= 0)
        {
            rb.AddForce(Vector2.down * queda);
            audioManager.PlayStomp(audioManager.Stomp);
        }
        else
        {
            timer -= Time.deltaTime;
            Stomp(animator);
        }
        
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    void Stomp(Animator anim)
    {
        anim.transform.position = posTop.position;
    }
}
