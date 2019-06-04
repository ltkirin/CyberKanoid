using UnityEngine;

namespace Cyberkanoid.Scripts.GameObjects.Controller.common
{
    public class BoardController : MonoBehaviour
    {
        [SerializeField] private Transform topBorder;
        [SerializeField] private Transform leftBorder;
        [SerializeField] private Transform rightBorder;
        [SerializeField] private int topPercent;
        [SerializeField] private int sidePercent;

        private Camera camera;

        private void Awake()
        {
            camera = Camera.main;
        }

        private void Update()
        {
            StayBorderPosition(topBorder, Stay.Top);
            StayBorderPosition(leftBorder, Stay.Left);
            StayBorderPosition(rightBorder, Stay.Right);
        }

        private void StayBorderPosition(Transform border, Stay stay)
        {
            int width = camera.pixelWidth;
            int height = camera.pixelHeight;

            Vector3 position;

            switch (stay)
            {
                case Stay.Top:
                    position = camera.ScreenToWorldPoint(new Vector2(width / 2, height));

                    border.localScale = new Vector3(camera.ScreenToWorldPoint(new Vector2(width, 0)).x / 2 + border.localScale.x * 0.125f,
                                                    camera.ScreenToWorldPoint(new Vector2(0, height)).y / (100 / topPercent),
                                                    border.localScale.z);

                    border.position = Vector2.right * position.x + Vector2.up * (position.y - border.localScale.y * 1.75f);
                    break;
                case Stay.Left:
                    position = camera.ScreenToWorldPoint(new Vector2(0, height / 2));

                    border.localScale = new Vector3(camera.ScreenToWorldPoint(new Vector2(width, 0)).x / (100 / sidePercent),
                                                    camera.ScreenToWorldPoint(new Vector2(0, height)).y / 2 + border.localScale.y * 0.125f,
                                                    border.localScale.z);

                    border.position = Vector2.right * (position.x + border.localScale.x * 1.75f) + Vector2.up * position;
                    break;
                case Stay.Right:
                    position = camera.ScreenToWorldPoint(new Vector2(width, height / 2));

                    border.localScale = new Vector3(camera.ScreenToWorldPoint(new Vector2(width, 0)).x / (100 / sidePercent),
                                                    camera.ScreenToWorldPoint(new Vector2(0, height)).y / 2 + border.localScale.y * 0.125f,
                                                    border.localScale.z);

                    border.position = Vector2.right * (position.x - border.localScale.x * 1.75f) + Vector2.up * position;
                    break;
                default:
                    position = camera.ScreenToWorldPoint(new Vector2(width / 2, height / 2));
                    border.position = Vector2.right * (position.x) + Vector2.up * position;
                    break;
            }
        }

        private enum Stay
        {
            Top,
            Left,
            Right
        }
    }
}
