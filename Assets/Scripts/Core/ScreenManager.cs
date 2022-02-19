//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RenderHeads
{
	public class ScreenManager
	{
		#region Public Properties

		#endregion

		#region Private Properties
		private int overlaySceneIndex = -1;
		#endregion

		#region Public Methods
		public void LoadScene(int index)
		{
			SceneManager.LoadScene(index);
		}

		internal void ShowBadTouchAnimation()
		{
			if (overlaySceneIndex < 0)
			{
				SceneManager.LoadScene(6, LoadSceneMode.Additive);
				overlaySceneIndex = 6;
			}
		}

		internal void ShowGoodTouchAnimation()
		{
			if (overlaySceneIndex < 0)
			{
				SceneManager.LoadScene(5, LoadSceneMode.Additive);
				overlaySceneIndex = 5;
			}
		}

		internal void HideTouchAnimation()
		{
			SceneManager.UnloadSceneAsync(overlaySceneIndex);

			overlaySceneIndex = -1;
			LevelManagerService.Instance.ResumeHands();
		}
		#endregion

		#region Private Methods

		#endregion
	}
}