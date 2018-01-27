﻿using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Barbarian : Class
    {        
        public List<Rage_Power> Rage_Powers { get; } = new List<Rage_Power>();

        public Barbarian(Character character) : base(character)
        {
        }

        public override void Level_1()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Fast_Movement(character));
            Class_Features.Add(new Barbarian_Class_Features().Rage());
        }

        public override void Level_2()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
            Class_Features.Add(new Barbarian_Class_Features().Uncanny_Dodge());
        }

        public override void Level_3()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Trap_Sense(this));
        }

        public override void Level_4()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_5()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Improved_Uncanny_Dodge());
        }

        public override void Level_6()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_7()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Damage_Reduction(character, this));
        }

        public override void Level_8()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_9()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_10()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_11()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Greater_Rage());
        }

        public override void Level_12()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_13()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_14()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Indomitable_Will());
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_15()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_16()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_17()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Tireless_Rage());
        }

        public override void Level_18()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }

        public override void Level_19()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_20()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Class_Features().Mighty_Rage());
            Class_Features.Add(new Barbarian_Class_Features().Rage_Powers(this));
        }
    }
}
