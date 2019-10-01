﻿using UnityEngine;
using System.Collections;

public class SteeringSeek : MonoBehaviour {

	Move move;

	// Use this for initialization
	void Start ()
    {
		move = GetComponent<Move>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        Steer(move.target.transform.position);
	}

	public void Steer(Vector3 target)
	{
        // TODO 1: accelerate towards our target at max_acceleration
        // use move.AccelerateMovement()

        Vector3 diff = move.target.transform.position - move.transform.position;
        diff.Normalize();
        diff *= move.max_mov_acceleration;

        move.AccelerateMovement(diff);
    }
}
