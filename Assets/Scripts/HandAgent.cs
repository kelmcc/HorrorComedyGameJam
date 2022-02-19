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

		public HandDetection HandDetection;
		#endregion

		#region Private Properties

		private bool _isSeeking = false;
		private bool _hasSetStance = false;
		private float _badTouchChance = 0.8f;
		private Transform targetTransform;
		#endregion

		#region Public Methods
		private void Start()
		{
			navMeshAgent = GetComponent<NavMeshAgent>();
			navMeshAgent.speed = 4.5f;
			HandDetection.SetFoundPlayerAction(FoundPlayer);
			HandDetection.SetLostPlayerAction(LostPlayer);

			StopSeeking();

			LevelManagerService.Instance.DeregisterHand(this);
		}

		private void FoundPlayer(Transform transform)
		{
			if (!_hasSetStance)
			{
				SetStance();
			}

			targetTransform = transform;
			StartSeeking();
		}

		internal void Unload()
		{
			LevelManagerService.Instance.DeregisterHand(this);
			Destroy(this.gameObject);
		}

		private void LostPlayer()
		{
			targetTransform = null;
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

		internal void Pause()
		{
			StopSeeking();
		}

		internal void Resume()
		{
			StartSeeking();
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