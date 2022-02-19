using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RenderHeads
{
	public class HandSpawner : MonoBehaviour
	{

		public GameObject agentPrefab;
		public int numAgents;

		private List<NavMeshAgent> agents = new List<NavMeshAgent>();

		public GameObject player;

		void Start()
		{
			if (player == null)
			{
				player = LevelManagerService.Instance.GetPlayer().gameObject;
			}
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
			newAgent.GetComponent<HandAgent>().SetTarget(player.transform);
		}
	}
}