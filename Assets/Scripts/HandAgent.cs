//RenderHeads - Jeff Rusch
using System;
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
		private bool _hasSetStance = false;
		private float _badTouchChance = 0.5f;
		#endregion

		#region Public Methods
		private void Start()
		{
			navMeshAgent = GetComponent<NavMeshAgent>();
			navMeshAgent.speed = 1.5f;
			HandDetection.SetFoundPlayerAction(FoundPlayer);
			HandDetection.SetLostPlayerAction(LostPlayer);

			StopSeeking();
		}

		private void FoundPlayer()
		{
			if (!_hasSetStance)
			{
				SetStance();
			}

			StartSeeking();
		}

		private void LostPlayer()
		{
			StopSeeking();
		}

		private void SetStance()
		{
			if (UnityEngine.Random.Range(0.0f, 1.0f) <= _badTouchChance)
			{
				TouchType = TouchType.Bad;
			}
			else
			{
				TouchType = TouchType.Good;
			}

			Debug.Log("Set type to " + TouchType);
		}

		public void SetTarget(Transform target)
		{
			this.targetTransform = target;
		}

		public void StartSeeking()
		{
			if (!_isSeeking)
			{
				_isSeeking = true;
				navMeshAgent.isStopped = false;
			}
		}

		public void StopSeeking()
		{
			if (_isSeeking)
			{
				_isSeeking = false;
				navMeshAgent.isStopped = true;
			}
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