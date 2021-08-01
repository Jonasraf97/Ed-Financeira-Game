﻿using UnityEngine;
using System.Collections;

public class FollowThePath : MonoBehaviour {

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    public int waypointIndex = 0;

    public bool moveAllowed = false;

	// Use this for initialization
	private void Start () 
    {
        transform.position = waypoints[waypointIndex].transform.position;
	}
	
	// Update is called once per frame
	private void Update () 
    {
        if (moveAllowed == true)
        {
            Move();
        }

    }

    private void Move()
    {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

                if (transform.position == waypoints[waypointIndex].transform.position)
                {
                    waypointIndex += 1;
                }
    }
}
