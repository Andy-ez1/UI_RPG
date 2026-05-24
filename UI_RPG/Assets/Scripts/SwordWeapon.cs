using UnityEngine;

public class SwordWeapon : Weapon
{
    public override void ApplyEffect(Character target)
    {
        Debug.Log("Sword: no special effect.");
    }
}