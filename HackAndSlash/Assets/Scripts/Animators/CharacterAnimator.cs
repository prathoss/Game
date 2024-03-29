﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    const float locomotionAnimationSmoothTime = 0.1f;
    NavMeshAgent agent;
    Animator animator;

    public AnimatorOverrideController overrideController;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();

        if (overrideController == null)
        {
            overrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        }        
        animator.runtimeAnimatorController = overrideController;
	}
	
	// Update is called once per frame
	 void Update () {
        float speedPercent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speedPercent, locomotionAnimationSmoothTime, Time.deltaTime);
	}
}
