using UnityEngine; // Core UnityEngine namespace for MonoBehaviour and other Unity features
public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject target; // The GameObject the camera will follow, set via the Unity Inspector

    private Vector3 offset; // The fixed offset distance between the camera and the target

    public float smoothSpeed = 0.125f; // Speed of the camera's smoothing effect during transitions

    private void Start()
    {
        // Initialize the offset only if a target is assigned
        if (target != null)
        {
            // Calculate the initial offset between the camera and the target's position
            offset = transform.position - target.transform.position;
        }
    }

    // LateUpdate is called after all Update calls have been completed
    void LateUpdate()
    {
        // Ensure the target exists to avoid null reference errors
        if (target != null)
        {
            // Calculate the desired position of the camera based on the target's position and the offset
            Vector3 desiredPosition = target.transform.position + offset;

            // Smoothly interpolate between the current position and the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Update the camera's position to the smoothed position
            transform.position = smoothedPosition;
        }
    }
}
