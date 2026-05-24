using UnityEngine;

public class HeavyWeapon : Weapon
{
    public override float GetDamage()
    {
        return baseDamage; 
    }

    public override void ApplyEffect(Character target)
    {
        target.DamageMultiplier = 0.5f;
        Debug.Log("Heavy hit! Enemy's next attack is weakened!");
    }
}