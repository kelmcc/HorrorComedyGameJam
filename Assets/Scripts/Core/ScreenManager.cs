//RenderHeads - Jeff Rusch
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
        #endregion

        #region Private Methods

        #endregion
    }
}