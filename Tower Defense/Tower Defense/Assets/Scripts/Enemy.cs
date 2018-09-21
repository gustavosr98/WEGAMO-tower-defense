﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] float speed;
    Transform target;
    int wavepointIndex = 0;

    Waypoints waypoints;

	// Use this for initialization
	void Start () {
        waypoints = FindObjectOfType<Waypoints>();
        target = waypoints.FirstTarget();
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void Move()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }
}
