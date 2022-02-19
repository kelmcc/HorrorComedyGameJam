//RenderHeads - Jeff Rusch
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
		#endregion

		#region Private Methods

		#endregion
	}
}