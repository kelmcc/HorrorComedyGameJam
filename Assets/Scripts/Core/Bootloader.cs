//RenderHeads - Jeff Rusch
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class Bootloader : MonoBehaviour
    {
		#region Public Properties

		#endregion

		#region Private Properties

		#endregion

		#region Public Methods
		public void Awake()
		{
			GameManagerService.Instance.Init();
			ScreenManagerService.Instance.Init();
		}
		#endregion

		#region Private Methods

		#endregion
	}
}