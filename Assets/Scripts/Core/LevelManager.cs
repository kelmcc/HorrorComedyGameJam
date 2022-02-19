//RenderHeads - Jeff Rusch
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
	public class LevelManager
	{
		#region Public Properties

		#endregion

		#region Private Properties
		private int pickupCount = 0;
		private int pickupWinCount = 3;
		private int badTouchCount = 0;
		private int badTouchLoseLevelCount = 3;
		private Player player = null;
		private List<HandAgent> handAgents = new List<HandAgent>();
		#endregion

		#region Public Methods
		public void StartLevel()
		{
			Debug.Log("Starting level");
			ResetLevel();

		}

		public void GetPetted(TouchType touchType)
		{
			if (touchType == TouchType.Bad)
			{
				badTouchCount++;
				ShowTouchAnimation(TouchType.Bad);
			}
			else
			{
				badTouchCount--;
				ShowTouchAnimation(TouchType.Good);
			}

			if (badTouchCount < 0)
			{
				badTouchCount = 0;
			}

			Debug.LogFormat("Get Petted({0}) (bad touches {1})", touchType, badTouchCount);

			if (badTouchCount >= badTouchLoseLevelCount)
			{
				LoseGame();
			}
		}

		private void ShowTouchAnimation(TouchType touchType)
		{
			if (touchType == TouchType.Bad)
			{
				ScreenManagerService.Instance.ShowBadTouchAnimation();
			}
			else
			{
				ScreenManagerService.Instance.ShowGoodTouchAnimation();
			}

			PauseHands();
		}

		internal void DeregisterHand(HandAgent handAgent)
		{
			handAgents.Remove(handAgent);
		}

		internal void RegisterHand(HandAgent handAgent)
		{
			handAgents.Add(handAgent);
		}

		public void PauseHands()
		{
			for (int i = 0; i < handAgents.Count; i++)
			{
				handAgents[i].Pause();
			}
		}

		public void ResumeHands()
		{
			for (int i = 0; i < handAgents.Count; i++)
			{
				handAgents[i].Resume();
			}
		}

		internal Player GetPlayer()
		{
			return player;
		}

		public void EndLevel()
		{
			Debug.Log("End level");
		}

		internal void RegisterPlayer(Player player)
		{
			this.player = player;
			Debug.Log("Registered Player");
		}

		internal void FoundPickup()
		{
			pickupCount++;
			Debug.LogFormat("Found Pickup ({0})", pickupCount);

			if (pickupCount >= pickupWinCount)
			{
				WinGame();
			}
		}

		public void LoseGame()
		{
			GameManagerService.Instance.LoseGame();
		}

		public void WinGame()
		{
			GameManagerService.Instance.WinGame();
		}

		#endregion

		#region Private Methods
		private void ResetLevel()
		{
			this.pickupCount = 0;
			this.badTouchCount = 0;
		}
		#endregion
	}
}