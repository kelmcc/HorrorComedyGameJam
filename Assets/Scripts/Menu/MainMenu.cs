//RenderHeads - Jeff Rusch
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
    public class MainMenu : MonoBehaviour
    {
        #region Public Properties
        
        #endregion

        #region Private Properties

        #endregion

        #region Public Methods
        public void StartGame()
		{
            GameManagerService.Instance.StartGame();
		}

        public void BackToMenu()
        {
            ScreenManagerService.Instance.LoadMenu();
        }
        #endregion

        #region Private Methods

        #endregion
    }
}