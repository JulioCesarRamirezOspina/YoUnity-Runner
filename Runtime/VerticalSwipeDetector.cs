using UnityEngine;
using UnityEngine.InputSystem;

namespace Yosoft.Runner
{

    public class VerticalSwipeDetector : MonoBehaviour
    {
        [SerializeField] private InputAction swipeAction;
        [SerializeField] private float swipeThreshold = 50.0f;
        [SerializeField] private double maximumTime = 0.5f;

        public delegate void SwipeEvent(bool up);
        public static event SwipeEvent OnSwipe;

        private void OnSwipeDetected(InputAction.CallbackContext context)
        {
            Vector2 swipe = context.ReadValue<Vector2>();
            
            var startTime = context.startTime;
            var endTime = context.time;
            Debug.Log($"Duration:{context.duration}  endTime:{endTime} startTime:{startTime}= {endTime - startTime}<={maximumTime}");
            Debug.Log($"Mathf.Abs({swipe.x},{swipe.y}) > ({swipeThreshold})swipeThreshold ");

            if (Mathf.Abs(swipe.y) > swipeThreshold && (endTime - startTime) <= maximumTime)
            {
                if (swipe.y > 0)
                {
                    Debug.Log("Swiped Up");
                    var position = transform.position;
                    Debug.DrawLine(position, position + Vector3.up * swipe.y, Color.green, 1.0f);
                    OnSwipe?.Invoke(true);

                }
                else
                {
                    Debug.Log("Swiped Down");
                    var position = transform.position;
                    Debug.DrawLine(position, position + Vector3.down * swipe.y, Color.red, 1.0f);
                    OnSwipe?.Invoke(false);
                }
            }
        }

        private void Start()
        {
            swipeAction.performed += OnSwipeDetected;
            swipeAction.Enable();
        }

        private void OnDestroy()
        {
            swipeAction.performed -= OnSwipeDetected;
            swipeAction.Disable();
        }
    }
}