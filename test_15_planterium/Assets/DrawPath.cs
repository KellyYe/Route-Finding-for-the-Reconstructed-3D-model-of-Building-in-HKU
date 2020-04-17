using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DrawPath : MonoBehaviour {

	// Use this for initialization
	Transform target;
	NavMeshAgent agent;
	LineRenderer line;

	void Start () {
		line = GetComponent<LineRenderer>();
		agent = GetComponent<NavMeshAgent>();
		getPath();
	
	}

	void getPath()
	{
		line.SetPosition(0, transform.position);
		agent.SetDestination(target.position);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
