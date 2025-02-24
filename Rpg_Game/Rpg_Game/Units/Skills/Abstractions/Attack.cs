using Rpg_Game.Units.Characters;

using Rpg_Game.Units.Items.Abstractions.Enums;

namespace Rpg_Game.Units.Skills.Abstractions;

public class Attack
{
    public int PlayerDamage { get; private set; }
    public int EnemyDamage { get; private set; }
    
    public void CalculateDamage(Hero hero)
    {
        switch (hero.Equipment.WeaponSlot.Item.WeaponType)
        {
            case WeaponType.Sword :
                hero.TotalDamage = hero.Attributes.Strength + hero.Equipment.WeaponSlot.Item.Attributes.Strength;
                break;
            case WeaponType.Staff :
                hero.TotalDamage = hero.Attributes.Intelligence + hero.Equipment.WeaponSlot.Item.Attributes.Intelligence;
                break;
            case WeaponType.Bow :
                hero.TotalDamage = hero.Attributes.Agility + hero.Equipment.WeaponSlot.Item.Attributes.Agility;
                break;
            default:
                hero.TotalDamage = hero.Attributes.Strength;
                break;
        }
    }

    public void CalculateDamage(Enemy enemy)
    {
        switch (enemy.Equipment.WeaponSlot.Item.WeaponType)
        {
            case WeaponType.Sword:
                enemy.TotalDamage = enemy.Attributes.Strength + enemy.Equipment.WeaponSlot.Item.Attributes.Strength;
                break;
            case WeaponType.Staff:
                enemy.TotalDamage = enemy.Attributes.Intelligence + enemy.Equipment.WeaponSlot.Item.Attributes.Intelligence;
                break;
            case WeaponType.Bow:
                enemy.TotalDamage = enemy.Attributes.Agility + enemy.Equipment.WeaponSlot.Item.Attributes.Agility;
                break;
            default:
                enemy.TotalDamage = enemy.Attributes.Strength;
                break;
        }
    }
    
    public void AttackEnemy(Hero hero, Enemy enemy)
    {
        
    }
}