using Cyberkanoid.GameObjects.Model.common;
using Cyberkanoid.Scripts.GameObjects.View.common;
using UnityEditor;

namespace Cyberkanoid.Scripts.GameObjects.Controller.common
{
    /// <summary>
    /// Base class for all game object Controllers
    /// </summary>
    public abstract class BaseController
    {
        #region Fields
        protected BaseModel model;
        protected BaseView view;
        #endregion

        #region Constructors
        /// <summary>
        /// Create new Object with pregenrated ID and View
        /// </summary>
        /// <param name="view">View component of the object</param>
        public BaseController(BaseView view)
        {
            AssignView(view);
        }
        /// <summary>
        /// Create new BaseController with pregenrated View component and ID
        /// </summary>
        /// <param name="view">View component of the object</param>
        /// <param name="id">Object ID</param>
        public BaseController(BaseView view, GUID id): this(view)
        {
        }
        /// <summary>
        /// Create new baseController with pregenrated ID
        /// </summary>
        /// <param name="id">ID of the object</param>
        public BaseController(GUID id)
        {

        }
        /// <summary>
        /// Create ampty controller with no assigned components
        /// </summary>
        public BaseController()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Object ID
        /// </summary>
        public GUID ID
        {
            get => model.Id;
        }
        /// <summary>
        /// Activity stae of the Object. 
        /// True = fully functional on the scene 
        /// False = has no scene functions, but still is stored in Objcet Pool
        /// </summary>
        public bool IsActive
        {
            get => model.IsActive;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Activate object on game scene
        /// </summary>
        public void Activate()
        {
            model.IsActive = true;
        }
        /// <summary>
        /// Deactivate object on game scene
        /// </summary>
        public void Deactivate()
        {
            model.IsActive = false;
        }
        /// <summary>
        /// Assign view to 
        /// </summary>
        /// <param name="view"></param>
        public void AssignView(BaseView view)
        {
            this.view = view;
            model.Position = view.transform.position;
        }
        #endregion
    }
}