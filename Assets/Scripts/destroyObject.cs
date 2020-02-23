using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : StateMachineBehaviour
{
  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
    Destroy(animator.gameObject.transform.parent.gameObject, stateInfo.length);
    Destroy(animator.gameObject, stateInfo.length);
    Debug.Log("Destroy!");
  }
}
