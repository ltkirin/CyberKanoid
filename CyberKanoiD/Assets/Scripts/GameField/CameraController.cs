using UnityEngine;

namespace Cyberkanoid.Scripts.GameObjects.Controller.common
{
    public class CameraController : MonoBehaviour
    {
        private void Awake()
        {
            Camera.main.aspect = 4f / 3f;
        }
    }
}
