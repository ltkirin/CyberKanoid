using Cyberkanoid.Scripts.GameObjects.Controller.common;
using System.Collections.Generic;
using UnityEditor;

namespace Cyberkanoid.Scripts.ObjectPool
{

    /// <summary>
    /// Object to store and find Game objects on the scene 
    /// </summary>
    public class ObjectPool
    {
        private static ObjectPool instance;

        private Dictionary<GUID, BaseController> objectsCollection;

        public static ObjectPool Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ObjectPool();
                }
                return instance;
            }
        }

        public void RegisterObject(BaseController controller)
        {

        }
    }
}