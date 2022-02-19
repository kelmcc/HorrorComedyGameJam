//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class HandDetection : MonoBehaviour
    {

		#region Public Properties

		#endregion

		#region Private Properties
		private Action<Transform> foundPlayerAction;
		private Action lostPlayerAction;
		#endregion

		#region Public Methods
		public void SetFoundPlayerAction(System.Action<Transform> action)
		{
			foundPlayerAction += action;
		}

		public void SetLostPlayerAction(System.Action action)
		{
			lostPlayerAction += action;
		}

		public void OnTriggerEnter(Collider other)
		{
			Player player = other.GetComponent<Player>();

			if (player != null)
			{
				foundPlayerAction(player.transform);
			}
		}

		public void OnTriggerExit(Collider other)
		{
			Player player = other.GetComponent<Player>();

			if (player != null)
			{
				lostPlayerAction();
			}
		}
		#endregion

		#region Private Methods

		#endregion
	}
}