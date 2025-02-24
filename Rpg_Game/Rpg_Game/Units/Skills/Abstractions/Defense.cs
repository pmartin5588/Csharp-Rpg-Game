using Rpg_Game.Units.Characters;

namespace Rpg_Game.Units.Skills.Abstractions;

public class Defense
{
    public int PlayerDefense { get; private set; }
    public int EnemyDefense { get; private set; }
    
    public void CalculateDefense(Hero hero)
    {
        PlayerDefense = hero.Attributes.Defense 
                        + hero.Equipment.ChestSlot.Item.Attributes.Defense 
                        + hero.Equipment.LegSlot.Item.Attributes.Defense;
    }

    public void CalculateDefense(Enemy enemy)
    {
        EnemyDefense = enemy.Attributes.Defense 
                        + enemy.Equipment.ChestSlot.Item.Attributes.Defense 
                        + enemy.Equipment.LegSlot.Item.Attributes.Defense;
    }
}