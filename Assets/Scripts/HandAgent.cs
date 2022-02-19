//RenderHeads - Jeff Rusch
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace RenderHeads
{
	public enum TouchType
	{
		Good,
		Bad
	}

	public class HandAgent : MonoBehaviour
	{
		#region Public Properties
		public TouchType TouchType = TouchType.Bad;
		public NavMeshAgent navMeshAgent;

		public Transform targetTransform;
		#endregion

		#region Private Properties

		private bool _isSeeking = false;
		#endregion

		#region Public Methods
		private void Start()
		{
			navMeshAgent = GetComponent<NavMeshAgent>();
			navMeshAgent.speed = 1.5f;
		}

		public void SetTarget(Transform target)
		{
			this.targetTransform = target;
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
			if (_isSeeking && targetTransform != null)
			{
				navMeshAgent.destination = targetTransform.position;
			}

		}
		#endregion

		#region Private Methods

		#endregion
	}
}