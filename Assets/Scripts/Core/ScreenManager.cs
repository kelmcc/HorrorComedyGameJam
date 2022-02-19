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

        #endregion

        #region Public Methods
        public void LoadScene(int index)
		{
            SceneManager.LoadScene(index);
		}

		internal void ShowBadTouchAnimation()
		{
			SceneManager.LoadScene(5, LoadSceneMode.Additive);
		}

		internal void ShowGoodTouchAnimation()
		{
			SceneManager.LoadScene(5, LoadSceneMode.Additive);
		}

		internal void HideTouchAnimation()
		{
			SceneManager.UnloadSceneAsync(5);
		}
		#endregion

		#region Private Methods

		#endregion
	}
}