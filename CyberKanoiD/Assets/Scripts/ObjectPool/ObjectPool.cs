using Cyberkanoid.Scripts.GameObjects.Controller.common;
using Cyberkanoid.Scripts.ObjectPool.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Cyberkanoid.Scripts.ObjectPool
{
    /// <summary>
    /// IObjectPool implementation, based on List collection
    /// </summary>
    public class ListBasedObjectPool : IObjectPool
    {
        /// <summary>
        /// All interactive objects, presented on the scene, active and not active ones
        /// </summary>
        private List<BaseController> objectsCollection = new List<BaseController>();

        #region Methods

        #region Objects adding and removing
        ///<inheritdoc />
        public void Register(BaseController controller)
        {
            if (!objectsCollection.Contains(controller))
            {
                objectsCollection.Add(controller);
            }
            else
            {
                throw new Exception($"Objects Collection allready contains {controller.ToString()}");
            }
        }
        ///<inheritdoc />
        public void Unregister(BaseController controller)
        {
            if (objectsCollection.Contains(controller))
            {
                objectsCollection.Remove(controller);
            }
            else
            {
                throw new Exception($"Objects Collection does not contain {controller.ToString()}");
            }
        }
        #endregion

        #region Object getting
        ///<inheritdoc />
        public BaseController GetByID(GUID id)
        {
            BaseController result = objectsCollection
                .Where(c => c.ID == id)
                .FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            throw new Exception($"Object with ID {id} is not registred in the Objects Collection");
        }
        ///<inheritdoc />
        public BaseController GetInactiveObjectOfType(Type type)
        {
            //Will be implementred after implementing objects factory
            throw new NotImplementedException();
        }
        ///<inheritdoc />
        public BaseController GetRandomObjectOfType(Type type)
        {
            //Will be implementred after implementing objects factory
            throw new NotImplementedException();
        }
        #endregion

        #region Object existance check
        ///<inheritdoc />
        public bool ActiveObjectOFTypeExisits(Type type)
        {
            return objectsCollection.
                Where(o => o.GetType() == type)
                .Where(o => o.IsActive == true)
                .Any();
        }
        ///<inheritdoc />
        public bool inactiveObjectOFTypeExisits(Type type)
        {
            return objectsCollection.
                Where(o => o.GetType() == type)
                .Where(o => o.IsActive == false)
                .Any();
        }
        #endregion

        #endregion
    }
}