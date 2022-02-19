//RenderHeads - Jeff Rusch
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

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}