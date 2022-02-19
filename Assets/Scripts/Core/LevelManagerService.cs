//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class LevelManagerService
    {
        #region Public Properties
		public static LevelManagerService Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new LevelManagerService();
				}

				return _instance;
			}
		}

        #endregion

        #region Private Properties
		private static LevelManagerService _instance;



		private LevelManager levelmanager;
		#endregion

		#region Public Methods
		public void Init()
		{
			levelmanager = new LevelManager();
			Debug.Log("Hello LevelManager");
		}

		internal void StartLevel()
		{
			levelmanager.StartLevel();
		}

		public void RegisterPlayer(Player player)
		{
			levelmanager.RegisterPlayer(player);
		}

		internal void FoundPickup()
		{
			levelmanager.FoundPickup();
		}

		internal void GetPetted(TouchType touchType)
		{
			levelmanager.GetPetted(touchType);
		}
		#endregion

		#region Private Methods

		#endregion
	}
}