using Rpg_Game.Units.Characters;
using Rpg_Game.Units.Items;
using Rpg_Game.Units.Items.Abstractions.Enums;
using Rpg_Game.Units.Items.Abstractions.Item;
using Rpg_Game.Units.Skills.SkillSet;
using Rpg_Game.Units.Skills.SkillSet.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

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
                case Chest chest:

                case WeaponType.Sword:
                    damage = hero.Attributes.Strength + hero.Equipment.WeaponSlot.Item.Attributes.Strength;
                    break;
                case WeaponType.Staff:
                    damage = hero.Attributes.Intelligence + hero.Equipment.WeaponSlot.Item.Attributes.Intelligence;
                    break;
                case WeaponType.Bow:
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
