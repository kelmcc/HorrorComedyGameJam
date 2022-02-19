using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HandsManager : MonoBehaviour
{

	public GameObject agentPrefab;
	public int numAgents;

	private List<NavMeshAgent> agents = new List<NavMeshAgent>();

	public GameObject player;

	void Start()
	{

		//CHANGE THIS TO SPAWN ON COMMAND
		for (int i = 0; i < numAgents; i++)
		{
			SpawnAgent();
		}
	}

	void SpawnAgent()
	{
		GameObject newAgent = GameObject.Instantiate(agentPrefab);
		newAgent.transform.position = new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-50f, 50f));
		NavMeshAgent navMeshAgent = newAgent.GetComponent<NavMeshAgent>();


		agents.Add(navMeshAgent);
	}

	void Update()
	{
		for (int i = 0; i < agents.Count; i++)
		{
			agents[i].destination = player.transform.position;
		}
	}
}
