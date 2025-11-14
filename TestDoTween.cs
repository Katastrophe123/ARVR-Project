using DG.Tweening;   // DOTween namespace (make sure DOTween is installed)
using UnityEngine;

public class TestDoTween : MonoBehaviour
{
    [SerializeField]
    private Vector3[] points;  // Array of target positions for the tween animation

    private void Start()
    {
        // Start the square sequence animation when the scene begins
        SquareSequence();
    }

    private void SquareSequence()
    {
        // Create a new sequence for chaining animations
        Sequence sequence = DOTween.Sequence();

        // Loop through each point in the array
        foreach (Vector3 point in points)
        {
            // Append a movement tween to move to each point over 1 second
            sequence.Append(transform.DOMove(point, 1f));
        }

        // Make the sequence repeat forever
        sequence.SetLoops(-1, LoopType.Restart);

        // Play the animation
        sequence.Play();
    }

    // Optional: Draw gizmos in the Scene view so you can see the points visually
    private void OnDrawGizmos()
    {
        if (points == null || points.Length == 0) return;

        Gizmos.color = Color.cyan;

        for (int i = 0; i < points.Length; i++)
        {
            // Draw small spheres for each point
            Gizmos.DrawSphere(points[i], 0.2f);

            // Draw connecting lines between consecutive points
            if (i < points.Length - 1)
                Gizmos.DrawLine(points[i], points[i + 1]);
        }

        // Close the loop visually (optional)
        if (points.Length > 1)
            Gizmos.DrawLine(points[points.Length - 1], points[0]);
    }
}
