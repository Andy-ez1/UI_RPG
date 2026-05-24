using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon selectedWeapon;
    
    public void SetWeapon(Weapon weapon)
    {
        selectedWeapon = weapon;
        Debug.Log("Weapon changed to: " + weapon.name);
    }

    public Weapon SelectedWeapon => selectedWeapon;

    public override void Attack(Character toHit)
    {
        toHit.GetHit(selectedWeapon);
        Debug.Log("Player attacks with " + selectedWeapon.name);
    }

    public void Heal()
    {
        Health += 2;
    }
}