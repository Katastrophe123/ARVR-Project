using System.Collections; // Namespace for collections (not used here but included by default)
using System.Collections.Generic; // Provides generic collection types (not used here)
using UnityEngine; // Core UnityEngine namespace for Unity scripting

public class Player : MonoBehaviour
{
    // Enum representing the four target positions the player can move to
    public enum TargetEnum
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

    public float speed = 5f; // Speed at which the player moves toward targets
    public TargetEnum nextTarget; // The current target position the player is moving towards

    // Predefined positions for the four targets in world space
    private Vector3 topLeftPosition = new Vector3(0f, 0.5f, 95f);
    private Vector3 topRightPosition = new Vector3(120f, 0.5f, 95f);
    private Vector3 bottomLeftPosition = new Vector3(120f, 0.5f, -23f);
    private Vector3 bottomRightPosition = new Vector3(0f, 0.5f, -23f);

    // Update is called once per frame
    void Update()
    {
        // Continuously move the player toward the current target
        MoveToTarget();
    }

    // Moves the player toward the current target position
    private void MoveToTarget()
    {
        Vector3 targetPosition = Vector3.zero; // Initialize the target position

        // Determine the target position based on the current target enum value
        switch (nextTarget)
        {
            case TargetEnum.TopLeft:
                targetPosition = topLeftPosition;
                break;
            case TargetEnum.TopRight:
                targetPosition = topRightPosition;
                break;
            case TargetEnum.BottomLeft:
                targetPosition = bottomLeftPosition;
                break;
            case TargetEnum.BottomRight:
                targetPosition = bottomRightPosition;
                break;
        }

        // Move the player's position closer to the target using Vector3.MoveTowards
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Check if the player has reached the target position
        if (transform.position == targetPosition)
        {
            Debug.Log(targetPosition); // Log the current target position
            NextTarget(); // Determine the next target
        }
    }

    // Updates the target to the next one in the sequence
    private void NextTarget()
    {
        // Cycle to the next target in the enum (wraps around to the first target after the last)
        nextTarget = (TargetEnum)(((int)nextTarget + 1) % System.Enum.GetValues(typeof(TargetEnum)).Length);

        // Log the updated target for debugging purposes
        Debug.Log("TargetEnum.nextTarget " + nextTarget);

        // Rotate the player to face the direction of the next target
        switch (nextTarget)
        {
            case TargetEnum.TopLeft:
                RotateTowards(0f); // Face forward
                break;
            case TargetEnum.TopRight:
                RotateTowards(90f); // Face right
                break;
            case TargetEnum.BottomLeft:
                RotateTowards(180f); // Face backward
                break;
            case TargetEnum.BottomRight:
                RotateTowards(-90f); // Face left
                break;
        }
    }

    // Rotates the player to face a specific angle
    private void RotateTowards(float angle)
    {
        transform.rotation = Quaternion.Euler(0f, angle, 0f); // Set the rotation to the specified angle
    }
}
