//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
	public class GameManager
	{
		#region Public Properties

		#endregion

		#region Private Properties

		#endregion

		#region Public Methods

		#endregion

		#region Private Methods

		#endregion
		internal void StartGame()
		{
			ScreenManagerService.Instance.LoadGame();
			LevelManagerService.Instance.StartLevel();
			ScreenManagerService.Instance.Reset();
		}

		internal void WinGame()
		{
			Debug.Log("Win Game");
			ScreenManagerService.Instance.WinScreen();
		}

		internal void LoseGame()
		{
			Debug.Log("Lose Game");
			ScreenManagerService.Instance.LoseScreen();
		}
	}
}