//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class GameManagerService
    {
        #region Public Properties
		public static GameManagerService Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new GameManagerService();
				}

				return _instance;
			}
		}

		#endregion

		#region Private Properties
		private static GameManagerService _instance;
		private GameManager gameManager;
        #endregion

        #region Public Methods
		public void Init()
		{
			gameManager = new GameManager();
			Debug.Log("Hello GameManager");
		}

		internal void StartGame()
		{
			gameManager.StartGame();
		}

		internal void WinGame()
		{
			gameManager.WinGame();
		}

		internal void LoseGame()
		{
			gameManager.LoseGame();
		}
		#endregion

		#region Private Methods

		#endregion
	}
}