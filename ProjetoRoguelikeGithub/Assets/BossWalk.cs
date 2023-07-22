using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWalk : StateMachineBehaviour
{
    public float speed = 2.5f;
     Transform player;
     Transform bossPos;
     Rigidbody2D bossrb;
     BossScript boss;
     GameObject paredeCol;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindWithTag("Player").transform;
        bossPos = animator.GetComponent<Transform>();
        bossrb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<BossScript>();
        paredeCol = GameObject.Find("ParedeCol");
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.OlharPlayer();

        Vector2 target = new Vector2(paredeCol.transform.position.x, bossPos.position.y);
        Vector2 newPos = Vector2.MoveTowards(bossPos.position, target, speed * Time.fixedDeltaTime);
        bossrb.MovePosition(newPos);
    }

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
