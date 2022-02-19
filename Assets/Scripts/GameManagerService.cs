//RenderHeads - Jeff Rusch
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

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}