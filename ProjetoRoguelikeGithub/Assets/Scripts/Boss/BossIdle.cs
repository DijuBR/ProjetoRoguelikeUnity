using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIdle : StateMachineBehaviour
{
    [Header("Timer")]
    public float tempoMin, tempoMax, timer;
    //OnStateEnter = Start mas para animação.
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EscolherState(animator);
        timer = Random.Range(tempoMin, tempoMax);
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
