using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWalk : StateMachineBehaviour
{
    public float speed;
     Transform player;
     Transform bossPos;
     Rigidbody2D bossrb;
     BossScript boss;
     GameObject paredeCol;

    [Header("Timer")]
    public float tempoMin, tempoMax, timer;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Sets(animator);
        timer = Random.Range(tempoMin, tempoMax);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(timer >= 0)
        {
            Andar(animator);
        }
        else
        {
            timer -= Time.deltaTime;
        }
        
    }

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    void Sets(Animator animator)
    {
        player = GameObject.FindWithTag("Player").transform;
        bossPos = animator.GetComponent<Transform>();
        bossrb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<BossScript>();
        paredeCol = GameObject.Find("ParedeCol");
    }
    void Andar(Animator animator)
    {
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, paredeCol.transform.position, speed * Time.deltaTime);
    }
}
