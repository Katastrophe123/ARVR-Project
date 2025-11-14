using System.Collections; // Namespace for handling collections (not used here but included by default)
using System.Collections.Generic; // Provides generic collection types (not used here)
using UnityEngine; // Core UnityEngine namespace for working with Unity's game objects, components, and more

public class CarMove : MonoBehaviour
{
    // Speed of the car movement, editable in the Unity Inspector due to SerializeField
    [SerializeField] private float speed;

    // Start is called before the first frame update
    // This is a Unity lifecycle method, typically used for initialization
    void Start()
    {
        // Currently empty, but can be used for initialization logic
    }

    // Update is called once per frame
    // This method is used for per-frame updates, such as handling input or moving objects
    void Update()
    {
        // Moves the game object forward along the Z-axis
        // The movement is scaled by 'speed' and Time.deltaTime to ensure frame-rate independence
        gameObject.transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
    }
}
