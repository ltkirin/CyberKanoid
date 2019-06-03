using Cyberkanoid.Scripts.GameObjects.Controller.common;
using UnityEditor;

namespace Cyberkanoid.Scripts.ObjectPool.interfaces
{
    /// <summary>
    /// Interface for OjectPools objects
    /// </summary>
    public interface IObjectPool 
{
        /// <summary>
        /// Register new objet in the pool
        /// </summary>
        /// <param name="objectToRegister">Object to register</param>
        void Register(BaseController objectToRegister);
        /// <summary>
        /// Remove object from pool (used whe removing object from scene is needed)
        /// </summary>
        /// <param name="objectToRemove"></param>
        void Unregister(BaseController objectToRemove);

        BaseController GetObject(GUID id);
}}