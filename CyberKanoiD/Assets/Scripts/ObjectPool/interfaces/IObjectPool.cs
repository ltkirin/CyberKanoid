using Cyberkanoid.Scripts.GameObjects.Controller.common;
using System;
using UnityEditor;

namespace Cyberkanoid.Scripts.ObjectPool.interfaces
{
    /// <summary>
    /// Interface for OjectPools objects
    /// </summary>
    public interface IObjectPool
    {
        /// <summary>
        /// Add a new object to collection
        /// </summary>
        /// <param name="controller">Object to add</param>
        /// 
        void Register(BaseController objectToRegister);
        /// <summary>
        /// Remove object from pool (used befor object is deleted from scene, if it is unnessesary< not after deactivting it)
        /// </summary>
        /// <param name="controller"></param>
        void Unregister(BaseController objectToRemove);
        /// <summary>
        /// Find exisiting object by ID 
        /// </summary>
        /// <param name="id">ID of the object</param>
        /// <returns>Object with specified ID</returns>
        BaseController GetByID(GUID id);
        /// <summary>
        /// Find random unused object of type. 
        /// </summary>
        /// <param name="type">Type of object to find</param>
        /// <returns>Find inactive object of type in pool, or create one, if there are no available</returns>
        BaseController GetInactiveObjectOfType(Type type);
        /// <summary>
        /// Find random active object of type from Object Pool
        /// </summary>
        /// <param name="type">Type of object to find</param>
        /// <returns>Active object of specified type, or null, if there is no one</returns>
        BaseController GetRandomObjectOfType(Type type);
        /// <summary>
        /// Check, if active object of specified type exists in th Object Pool
        /// </summary>
        /// <param name="type">Needed type of the object</param>
        /// <returns></returns>
        bool ActiveObjectOFTypeExisits(Type type);
        /// <summary>
        /// Check, if inactive object of specified type exists in th Object Pool
        /// </summary>
        /// <param name="type">Needed type of the object</param>
        /// <returns></returns>
        bool inactiveObjectOFTypeExisits(Type type);

    }
}