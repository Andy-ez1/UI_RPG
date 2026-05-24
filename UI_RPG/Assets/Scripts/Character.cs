using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private string charName;

    public string CharName => charName;

    private float health;
    [SerializeField] internal float maxHealth;

    public float Health
    {
        get { return health; }
        set { health = Mathf.Max(0, value); }
    }
    
    public float DamageMultiplier { get; set; } = 1f;
    
    public bool IsAlive => health > 0;

    public abstract void Attack(Character toHit);

    private void Awake()
    {
        health = maxHealth;
    }
    
    public void GetHit(float damage)
    {
        health = Mathf.Max(0, health - damage);
        Debug.Log(charName + " got hit for " + damage + "! HP: " + health);
    }
    
    public void GetHit(Weapon weapon)
    {
        float damage = weapon.GetDamage();
        health = Mathf.Max(0, health - damage);
        weapon.ApplyEffect(this); 
        Debug.Log(charName + " got hit by " + weapon.name + " for " + damage + "! HP: " + health);
    }
}