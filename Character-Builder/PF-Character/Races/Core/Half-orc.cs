﻿using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Races.Core.Racial_Traits;

namespace PF_Character.Races.Core
{
    public class Half_orc : Race
    {
        public Half_orc(string bonus, Character character) : base(character)
        {
            switch (bonus)
            {
                case "Strength":
                    Strength_Bonus = 2;
                    break;
                case "Dexterity":
                    Dexterity_Bonus = 2;
                    break;
                case "Constitution":
                    Constitution_Bonus = 2;
                    break;
                case "Intelligence":
                    Intelligence_Bonus = 2;
                    break;
                case "Wisdom":
                    Wisdom_Bonus = 2;
                    break;
                case "Charisma":
                    Charisma_Bonus = 2;
                    break;
                default:
                    break;
            }

            Race_Name = "Half orc";

            Size = new Size().Medium();

            Type = "Humanoid (human, orc)";

            Base_Speed = 30;

            Langauges.Add("Common");
            Langauges.Add("Orc");

            Racial_Traits.Add(new Half_orc_Racial_Trait().Intimidating());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Orc_Ferocity());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Weapon_Familiarity());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Darkvision());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Orc_Blood());
        }

        public override void SetBonus(string bonus)
        {
            switch (bonus)
            {
                case "Strength":
                    Strength_Bonus = 2;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Dexterity":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 2;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Constitution":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 2;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Intelligence":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 2;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Wisdom":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 2;
                    Charisma_Bonus = 0;
                    break;
                case "Charisma":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 2;
                    break;
                default:
                    break;
            }
        }
    }
}
