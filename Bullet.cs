using UnityEngine; 
public class Bullet : MonoBehaviour 
{ 
// This function runs automatically when the bullet's collider hits another collider 
private void OnCollisionEnter(Collision collision) 
{ 
// Check if the object we hit has the "Target" tag (our red cubes) 
if (collision.gameObject.CompareTag("Target")) 
{ 
// Destroy the target object 
Destroy(collision.gameObject); 
// Find the ScoreManager in the scene and tell it to add a point 
// This is a simple way to find it, but for a bigger game, we'd use a singleton 
FindObjectOfType<ScoreManager>().AddPoint(); 
} 
// Destroy the bullet itself no matter what it hits 
Destroy(gameObject); 
} 
} 
