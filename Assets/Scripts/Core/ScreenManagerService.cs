//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class ScreenManagerService
    {
        #region Public Properties
		public static ScreenManagerService Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new ScreenManagerService();
				}

				return _instance;
			}
		}

        #endregion

        #region Private Properties
		private static ScreenManagerService _instance;
		private ScreenManager screenManager;

		#endregion

		#region Public Methods
		public void Init()
		{
			screenManager = new ScreenManager();
			Debug.Log("Hello ScreenManager");
		}

		public void LoadMenu()
		{
			screenManager.LoadScene(1);
		}

		internal void ShowBadTouchAnimation()
		{
			screenManager.ShowBadTouchAnimation();
		}

		internal void ShowGoodTouchAnimation()
		{
			screenManager.ShowGoodTouchAnimation();
		}

		internal void HideTouchAnimation()
		{
			screenManager.HideTouchAnimation();
		}

		public void LoadGame()
		{
			screenManager.LoadScene(2);
		}

		internal void WinScreen()
		{
			screenManager.LoadScene(3);
		}

		internal void LoseScreen()
		{
			screenManager.LoadScene(4);
		}

		public void Reset()
		{
			screenManager.Reset();
		}
		#endregion

		#region Private Methods

		#endregion
	}
}