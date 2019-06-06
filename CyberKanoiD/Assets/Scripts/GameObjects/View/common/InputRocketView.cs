using UnityEngine;
using System.Collections;

using Cyberkanoid.GameObjects.Model.common;
using Cyberkanoid.GameObjects.Controller.common;

namespace Cyberkanoid.Scripts.GameObjects.View.common
{
    public class InputRocketView : MonoBehaviour
    {
        [SerializeField] private RocketModel model;
        [SerializeField] private RocketController controller;

        private void Awake()
        {
            controller = new RocketController();
        }

        private void FixedUpdate()
        {
#if UNITY_STANDALONE
            if (Input.GetKey(KeyCode.A))
            {
                controller.MoveLeft(model);
            }
            else if(Input.GetKey(KeyCode.D))
            {
                controller.MoveRight(model);
            }
            else
            {
                controller.Stop(model);
            }
#elif UNITY_ANDROID || UNITY_IOS
            // По оброзу и подобию STANDALONE
#endif
            if ((model.Transform.position.x <= model.MaxLeftPosition && model.Speed < 0) ||
                (model.Transform.position.x >= model.MaxRightPosition && model.Speed > 0))
            {
                model.Speed = 0;
            }
            controller.Move(model);
        }

        }
    }
