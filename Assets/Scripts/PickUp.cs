//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
	public class PickUp : MonoBehaviour
	{
		#region Public Properties

		#endregion

		#region Private Properties

		#endregion

		#region Public Methods

		#endregion

		#region Private Methods

		#endregion
		internal void Unload()
		{
			Destroy(this.gameObject);
		}
	}
}