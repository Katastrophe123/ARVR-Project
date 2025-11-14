using UnityEngine; 
using UnityEngine.InputSystem; 
public class GunShoot : MonoBehaviour 
{ 
// Assign the bullet prefab in the Inspector 
public GameObject bulletPrefab; 
// Assign an empty 'Transform' object at the gun's barrel 
public Transform spawnPoint; 
// Set the speed of the bullet 
public float bulletSpeed = 20f; 
// This function is called by the 'Input Action' (when trigger is pressed) 
public void Fire(InputAction.CallbackContext context) 
{ 
// Check if the button was just pressed down 
if (context.performed) 
{ 
// Create a new bullet at the spawn point's position and rotation 
GameObject 
spawnPoint.rotation); 
bullet 
= 
Instantiate(bulletPrefab, 
spawnPoint.position, 
// Get the Rigidbody from the bullet we just made 
Rigidbody rb = bullet.GetComponent<Rigidbody>(); 
// Add force to the bullet to make it move forward 
rb.AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse); 
// Destroy the bullet after 3 seconds so they don't fill the scene 
Destroy(bullet, 3.0f); 
} 
} 
} 
