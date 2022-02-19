//RenderHeads - Jeff Rusch
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class Billboard : MonoBehaviour
    {
		#region Public Properties

		#endregion

		#region Private Properties

		#endregion

		#region Public Methods
		public void Update()
		{
			this.transform.LookAt(Camera.main.transform, Vector3.up);
		}
		#endregion

		#region Private Methods

		#endregion
	}
}