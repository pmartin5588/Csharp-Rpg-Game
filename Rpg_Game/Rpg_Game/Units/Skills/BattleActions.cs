using Rpg_Game.Units.Characters;
using Rpg_Game.Units.Items;
using Rpg_Game.Units.Items.Abstractions.Item;
using Rpg_Game.Units.Items.Abstractions.Item.Weapon;
using Rpg_Game.Units.Skills.SkillSet;
using Rpg_Game.Units.Skills.SkillSet.Abstractions;

namespace Rpg_Game.Units.Skills
{
    internal class BattleActions
    {
        private Magic[] magics;

        public BattleActions()
        {
            magics =
            [
                new Fireball(),
                new IceSpike()
            ];
        }


        public void Attack(Hero hero, Enemy enemy)
        {
            var damage = 0;
            switch (hero.Equipment.WeaponSlot.Item)
            {
                case Sword sword:
                    damage = hero.Attributes.Strength + hero.Equipment.WeaponSlot.Item.Attributes.Strength;
                    break;
                case Staff staff:
                    damage = hero.Attributes.Intelligence + hero.Equipment.WeaponSlot.Item.Attributes.Intelligence;
                    break;
                case Bow bow:
                    damage = hero.Attributes.Agility + hero.Equipment.WeaponSlot.Item.Attributes.Agility;
                    break;
                default:
                    damage = hero.Attributes.Strength;
                    break;
            }

            enemy.TakeDamage(damage);
        }

        public void Defense(Hero hero)
        {
            
        }

        public void UseMagic(Hero hero, Enemy enemy, Magic magic)
        {
            enemy.TakeDamage(magic.CalculateFinalDamage(hero));
        }
    }
}
