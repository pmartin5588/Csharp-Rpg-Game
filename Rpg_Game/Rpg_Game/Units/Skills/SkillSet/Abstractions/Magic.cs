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

        public int CalculateFinalDamage(Character character)
        {
            return (int)(BaseDamage + character.Attributes.Intelligence * 0.1 + (character.Equipment.WeaponSlot.Item?.Attributes.Intelligence ?? 0) * 0.1);
        }
    }
}
