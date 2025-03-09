using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Skills.SkillSet.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Units.Skills.SkillSet
{
    internal class Fireball : Magic
    {
        public Fireball(Character character) : base(character)
        {
        }
        
        public override string Name { get; } = nameof(Fireball);

        public override int Cost { get; } = 8;

        public override int BaseDamage { get; } = 20;
        
        
    }
}
