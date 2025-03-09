using Rpg_Game.Units.Characters.Abstractions;
using Rpg_Game.Units.Characters.Hero;
using Rpg_Game.Units.Items;
using Rpg_Game.Units.Items.Abstractions.Item;
using Rpg_Game.Units.Items.Abstractions.Item.Weapon;
using Rpg_Game.Units.Skills.SkillSet;
using Rpg_Game.Units.Skills.SkillSet.Abstractions;

namespace Rpg_Game.Units.Skills
{
    public class BattleActions
    {
        public List<string> ListOfBattleActions = new List<string>();
        public Magic[] Magics { get; }
        private Character Character;

        public BattleActions(Character character)
        {
            Character = character;
            this.AddActionToList("Attack");
            this.AddActionToList("Defend");
            Magics =
            [
                new Fireball(character),
                new IceSpike(character)
            ];
            foreach (var magic in Magics)
            {
                this.AddActionToList(magic.Name);
            }
        }
        
        public void AddActionToList(string action)
        {
            if (ListOfBattleActions.Contains(action))
            {
                Console.WriteLine("Battle action is already added to list.");
            }
            ListOfBattleActions.Add(action);
        }

        public void RemoveActionFromList(string action)
        {
            if (!ListOfBattleActions.Contains(action))
            {
                Console.WriteLine("Battle action is not added to list.");
            }
            else if (action == "Attack" || action == "Defense")
            {
                Console.WriteLine("Basic actions could not be removed.");
            }
            ListOfBattleActions.Remove(action);
        }
        
        public void Attack(Character target)
        {
            var damage = 0;
            switch (Character.Equipment.WeaponSlot.Item)
            {
                case Sword sword:
                    damage = Character.Attributes.Strength + Character.Equipment.WeaponSlot.Item.Attributes.Strength;
                    break;
                case Staff staff:
                    damage = Character.Attributes.Intelligence + Character.Equipment.WeaponSlot.Item.Attributes.Intelligence;
                    break;
                case Bow bow:
                    damage = Character.Attributes.Agility + Character.Equipment.WeaponSlot.Item.Attributes.Agility;
                    break;
                default:
                    damage = Character.Attributes.Strength;
                    break;
            }

            Console.WriteLine($"{Character.Name} attacked {target.Name}.\r\n");
            target.TakeDamage(damage);
        }

        public void Defense(Hero hero)
        {
            
        }

    }
}
