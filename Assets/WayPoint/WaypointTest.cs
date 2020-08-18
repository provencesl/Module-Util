using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointTest : MonoBehaviour {

	private NavMeshAgent agent;

	public List<Transform> wayPointList = new List<Transform>();

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();

		HeadNext(2);
	}

	private void HeadNext(int i)
	{
		

		agent.SetDestination(wayPointList[i].position);

	}


	// Update is called once per frame
	void Update () {
		
	}
}
