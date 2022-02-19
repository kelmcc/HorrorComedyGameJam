using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Seek : MonoBehaviour
{
	public NavMeshAgent navMeshAgent;

	public Transform playerTransform;

	private bool _isSeeking = false;

	private void Start()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		navMeshAgent.speed = 1.5f;
	}

	public void SetTarget(Transform playerTransform)
	{
		this.playerTransform = playerTransform;
	}

	public void StartSeeking()
	{
		_isSeeking = true;
	}

	public void StopSeeking()
	{
		_isSeeking = false;
		navMeshAgent.isStopped = false;
	}

	void Update()
	{
		if (_isSeeking)
		{
			navMeshAgent.destination = playerTransform.position;
		}

	}
}
