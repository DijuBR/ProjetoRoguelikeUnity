using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : StateMachineBehaviour
{
    [Header("Refs")]
    public GameObject tiroBoss;
    public GameObject tiroBoss2;
    public Transform tiroPos;

    [Header("Timer")]
    public float tempoMin;
    public float tempoMax;
    public float timer;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        tiroPos = GameObject.FindWithTag("BossTiroPos").GetComponent<Transform>();   
        timer = Random.Range(tempoMin, tempoMax);
    }

// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
    void Atirar()
    {
        Instantiate(tiroBoss, tiroPos.transform);
        
    }
}
