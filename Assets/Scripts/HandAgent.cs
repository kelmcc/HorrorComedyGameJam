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
		public HandDetection HandDetection;
		#endregion

		#region Private Properties

		private bool _isSeeking = false;
		#endregion

		#region Public Methods
		private void Start()
		{
			navMeshAgent = GetComponent<NavMeshAgent>();
			navMeshAgent.speed = 1.5f;
			HandDetection.SetFoundPlayerAction(StartSeeking);
			HandDetection.SetLostPlayerAction(StopSeeking);

			StopSeeking();
		}

		public void SetTarget(Transform target)
		{
			this.targetTransform = target;
		}

		public void StartSeeking()
		{
			Debug.Log("Start Seeking");
			_isSeeking = true;
			navMeshAgent.isStopped = false;
		}

		public void StopSeeking()
		{
			Debug.Log("Stop Seeking");
			_isSeeking = false;
			navMeshAgent.isStopped = true;
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