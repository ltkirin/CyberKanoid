using Cyberkanoid.Scripts.GameObjects.Controller.common;
using UnityEditor;
using UnityEngine;

namespace Cyberkanoid.Scripts.GameObjects.View.common
{

    public abstract class BaseView : MonoBehaviour
    {
        [SerializeField]
        protected GUID id;
        protected BaseController controller;

        /// <summary>
        /// Object ID
        /// WARNING! Backing filed is made for development and testing purposes
        /// Later shall ber removed and taken directly from controller
        /// </summary>
        public GUID Id
        {
            get => id;
            //Switch for that variant on late developmaen phase
            //get => controller.ID
        }

        /// <summary>
        /// Temporally used method to set ID to backing field ID
        /// For visualiztion in Inspector.
        /// later ahsll ber removed 
        /// </summary>
        private void SetId()
        {
            id = controller.ID;
        }
    }
}