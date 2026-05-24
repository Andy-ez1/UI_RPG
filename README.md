# UI_RPG
UI_RPG
# RPG spele

## Par speli
Spele ir rpg tips kur var cīnīties pret pretiniekiem. 
Speletajs var izvēlēties ieroci un uzbrukt. Kad pretinieks nomirst 
parādās jauns. Ja speletajam beidzas hp tad spele beidzas.

## OOP principi

### Mantošana
Izveidoju Character klasi no kuras manto Player un Enemy klases. 
MageEnemy manto no Enemy klases. Ierociem ir Weapon klase no 
kuras manto SwordWeapon, ChargeWeapon un HeavyWeapon.

### Enkapsulācija
Health mainīgais ir private un tam ir getter un setter lai 
nevarētu uzlikt negatīvu hp. SelectedWeapon arī ir private 
un to var mainīt tikai caur SetWeapon metodi.

### Polimorfisms
Attack metode ir override gan Player gan Enemy gan MageEnemy 
klasēs jo katram ir savādāks uzbrukums. GetHit metodei ir 
overload versija - viena panem float skaitli otra panem Weapon.

### Abstrakcija
Weapon klase ir abstrakta. Tai ir GetDamage metode un abstrakta 
ApplyEffect metode kuru katrs ierocis implementē savādāk.

## Papilduzdevumi
Izdarīju 2 papilduzdevumus:
- 2 pretinieki - parasts Warrior un Mage kas sev atjauno hp
- 3 ieroči - Sword, ChargeWeapon kas katru reizi dara vairāk 
  damage, un HeavyWeapon kas novājina pretinieku
