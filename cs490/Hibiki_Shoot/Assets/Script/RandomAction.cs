﻿using UnityEngine;
using System.Collections;


public class RandomAction : StateMachineBehaviour {

    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
//	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
//		Debug.Log("OnStateEnter");
//	}

	// OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called before OnStateExit is called on any state inside this state machine
//	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
//		Debug.Log("OnStateExit");
//	}

	// OnStateMove is called before OnStateMove is called on any state inside this state machine
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called before OnStateIK is called on any state inside this state machine
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMachineEnter is called when entering a statemachine via its Entry Node
	override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
		Debug.Log("OnStateMachineEnter");
		float rotation = Random.Range (-30.0f, 30.0f);
		animator.SetInteger ("actionID", Random.Range(0, 3));
		animator.SetInteger ("actionID", 0);
		if (animator.GetInteger ("actionID") == 0 || animator.GetInteger ("actionID") == 3)
			animator.transform.Rotate (0, rotation, 0);
	}

	// OnStateMachineExit is called when exiting a statemachine via its Exit Node
//	override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
//		Debug.Log("OnStateMachineExit");
//	}
}
