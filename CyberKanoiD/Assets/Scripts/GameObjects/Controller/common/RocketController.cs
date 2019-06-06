using UnityEngine;

using Cyberkanoid.GameObjects.Model.common;

namespace Cyberkanoid.GameObjects.Controller.common
{
    public class RocketController
    {
        public void MoveRight(RocketModel rocket)
        {
            if (rocket.Speed < rocket.MaxSpeed - 0.1f)
            {
                rocket.Speed = Mathf.Lerp(rocket.Speed, rocket.MaxSpeed, Time.fixedDeltaTime * rocket.SmoothMovement);
            }
            else
            {
                rocket.Speed = rocket.MaxSpeed;
            }
        }

        public void MoveLeft(RocketModel rocket)
        {
            if (rocket.Speed > 0.1f - rocket.MaxSpeed)
            {
                rocket.Speed = Mathf.Lerp(rocket.Speed, -rocket.MaxSpeed, Time.fixedDeltaTime * rocket.SmoothMovement);
            }
            else
            {
                rocket.Speed = -rocket.MaxSpeed;
            }
        }

        public void Stop(RocketModel rocket)
        {
            if (rocket.Speed > 0.1f || rocket.Speed < -0.1f)
            {
                rocket.Speed = Mathf.Lerp(rocket.Speed, 0, Time.fixedDeltaTime * rocket.SmoothStop);
            }
            else
            {
                rocket.Speed = 0;
            }
        }

        public void Move(RocketModel rocket)
        {
            rocket.transform.Translate(Vector2.right * rocket.Speed, Space.World);
        }
    }
}
