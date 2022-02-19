//RenderHeads - Jeff Rusch
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class TouchScreen : MonoBehaviour
    {
		#region Public Properties

		#endregion

		#region Private Properties
		private float screenTimeUp = 0f;
		public float screenDuration = 1f;
		#endregion

		#region Public Methods
		public void Start()
		{
			screenTimeUp = Time.unscaledTime + screenDuration;
		}

		public void Update()
		{
			if (Time.unscaledTime > screenTimeUp)
			{
				ScreenManagerService.Instance.HideTouchAnimation();
			}
		}
		#endregion

		#region Private Methods

		#endregion
	}
}