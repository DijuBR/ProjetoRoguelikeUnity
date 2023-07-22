using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIdle : StateMachineBehaviour
{
    
    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EscolherState(animator);
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    void EscolherState(Animator animator)
    {
        int r = Random.Range(1, 4);
        switch (r)
        {
            case (1):
                animator.SetTrigger("isWalk");
                break;
            case (2):
                animator.SetTrigger("isShooting");
                break;
            case (3):
                animator.SetTrigger("isJumping");
                break;
        }
    }
}
