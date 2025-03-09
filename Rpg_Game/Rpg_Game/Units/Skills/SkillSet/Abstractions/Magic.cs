using Rpg_Game.Units.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game.Units.Characters.Abstractions;

namespace Rpg_Game.Units.Skills.SkillSet.Abstractions
{
    public abstract class Magic
    {
        public abstract string Name { get; }

        public abstract int Cost { get; }

        public abstract int BaseDamage { get; }

        private Character Character { get; }

        protected Magic(Character character)
        {
            Character = character;
        }

        public void Cast(Character target)
        {
            Character.TakeMana(Cost);

            Console.WriteLine($"{Character.Name} used {Name} on {target.Name}.\r\n");

            target.TakeDamage((int)(BaseDamage + Character.Attributes.Intelligence * 0.5 + (Character.Equipment.WeaponSlot.Item?.Attributes.Intelligence ?? 0) * 0.5));
        }
    }
}
