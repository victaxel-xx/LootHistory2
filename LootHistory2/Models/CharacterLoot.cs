using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootHistory2.Models
{
    public class CharacterLoot
    {
        public Character CurrentCharacter { get; set; }
        public List<LootEvent> CharacterLootEvents { get; set; }

        public CharacterLoot(Character currentChar, List<LootEvent> charLootEvents)
        {
            CurrentCharacter = currentChar;
            CharacterLootEvents = charLootEvents;

        }
    }
}