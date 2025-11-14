using UnityEngine; // Core Unity namespace for MonoBehaviour, ScriptableObject, and other features

// Creates a menu item in the Unity Editor to easily create TowerData assets
[CreateAssetMenu (menuName = "Data/TowerData")]
public class TowerData : ScriptableObject
{
    // Reference to the basic tower prefab or configuration
    //[SerializeField] private BasicTower basicTower;

    // Reference to the projectile used by the tower
    //[SerializeField] private TowerProjectile towerProjectile;

    // Attack range of the tower in game units
    [SerializeField] private float attackRange;

    // Amount of damage dealt by the tower per attack
    [SerializeField] private float damage;

    // Time (in seconds) between consecutive attacks
    [SerializeField] private float attackCoolDown;

    // Speed of the projectiles fired by the tower
    [SerializeField] private float projectileSpeed;

    // Icon representing the tower, used in UI or selection menus
    [SerializeField] private Sprite icon;

    // Name of the tower
    [SerializeField] private string nameTower;

    // Public properties to expose private fields while maintaining encapsulation
    //public BasicTower BasicTower => basicTower; // Gets the basic tower reference
    //public TowerProjectile TowerProjectile => towerProjectile; // Gets the projectile reference
    public float AttackRange => attackRange; // Gets the attack range
    public float Damage => damage; // Gets the damage value
    public float AttackCoolDown => attackCoolDown; // Gets the attack cooldown
    public float ProjectileSpeed => projectileSpeed; // Gets the projectile speed
    public Sprite Icon => icon; // Gets the tower icon
    public string NameTower => nameTower; // Gets the tower name
}
