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
        private int score = 0;
        private Player player = null;
        #endregion

        #region Public Methods
        public void StartLevel()
		{
            Debug.Log("Starting level");
            ResetLevel();

        }

        public void PickUp()
        {
            Debug.Log("Pickup");
        }

        public void GetPetted(TouchType touchType)
        {
            Debug.LogFormat("Get Petted ({0})", touchType);
        }

        public void EndLevel()
		{
            Debug.Log("End level");
        }

        public void WinGame()
        {
            GameManagerService.Instance.WinGame();
        }

		internal void RegisterPlayer(Player player)
		{
            this.player = player;
            Debug.Log("Registered Player");
        }

		internal void FoundPickup()
		{
            score++;
            Debug.LogFormat("Found Pickup ({0})", score);
        }

		public void LoseGame()
        {
            GameManagerService.Instance.LoseGame();
        }
        #endregion

        #region Private Methods
        private void ResetLevel()
		{
            this.score = 0;
		}
        #endregion
    }
}