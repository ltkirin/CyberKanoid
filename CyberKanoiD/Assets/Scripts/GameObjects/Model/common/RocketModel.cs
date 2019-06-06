using UnityEngine;

namespace Cyberkanoid.GameObjects.Model.common
{
    public class RocketModel : MonoBehaviour
    {
        [SerializeField] private float _maxSpeed;
        [SerializeField] private float _smoothMovement;
        [SerializeField] private float _smoothStop;
        [SerializeField] private float _maxLeftPosition;
        [SerializeField] private float _maxRightPosition;

        [HideInInspector] private Transform _transform;

        public float MaxSpeed { get { return _maxSpeed; } }
        public float SmoothMovement { get { return _smoothMovement; } }
        public float SmoothStop { get { return _smoothStop; } }
        public float MaxLeftPosition { get { return _maxLeftPosition; } }
        public float MaxRightPosition { get { return _maxRightPosition; } }
        public Transform Transform { get { return _transform; } }
        
        public float Speed { get; set; }

        private void Awake()
        {
            Speed = 0;
            _transform = transform;
        }

        private void OnValidate()
        {
            if (_maxSpeed < 0)
            {
                _maxSpeed = 0;
            }
            if (_smoothMovement <= 0)
            {
                _smoothMovement = 1;
            }
            if (_smoothStop <= 0)
            {
                _smoothStop = 1;
            }
        }
    }
}