//RenderHeads - Jeff Rusch
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

        #endregion

        #region Public Methods
        public void StartLevel()
		{
            Debug.Log("Starting level");
		}

        public void PickUp()
        {
            Debug.Log("Pickup");
        }

        public void GetPetted()
        {
            Debug.Log("Get Petted");
        }

        public void EndLevel()
		{
            Debug.Log("End level");
        }

        public void WinGame()
        {
            GameManagerService.Instance.WinGame();
        }

        public void LoseGame()
        {
            GameManagerService.Instance.LoseGame();
        }
        #endregion

        #region Private Methods

        #endregion
    }
}