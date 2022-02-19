using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshLogik : MonoBehaviour
{

	public GameObject agentPrefab;
	public int numAgents;

	private List<NavMeshAgent> agents = new List<NavMeshAgent>();

	public GameObject player;

	void Start()
	{

		//create the NavMesh agents
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

	// Update is called once per frame
	void Update()
	{
		//TODO: MOVE TO A ON VALUE CHANGED FUNCTION
		for (int i = 0; i < agents.Count; i++)
		{
			agents[i].destination = player.transform.position;
		}
	}
}
