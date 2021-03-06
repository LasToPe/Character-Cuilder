﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Magic
{
    class Magic_School
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    class Sub_School : Magic_School
    {
        public Magic_School Associated_School { get; set; }
    }

    class Abjuration : Magic_School
    {
        public Abjuration()
        {
            Name = "Abjuration";
            Description = "Abjurations are protective spells. They create physical or magical barriers, negate magical or physical abilities, harm trespassers, or even banish the subject of the spell to another plane of existence."
                + "\n\n" +
                "If one abjuration spell is active within 10 feet of another for 24 hours or more, the magical fields interfere with each other and create barely visible energy fluctuations. The DC to find such spells with the Perception skill drops by 4."
                + "\n\n" +
                "If an abjuration creates a barrier that keeps certain types of creatures at bay, that barrier cannot be used to push away those creatures. If you force the barrier against such a creature, you feel a discernible pressure against the barrier. If you continue to apply pressure, you end the spell.";
        }
    }

    class Conjuration : Magic_School
    {
        public Conjuration()
        {
            Name = "Conjuration";
            Description = "Each conjuration spell belongs to one of five subschools. Conjurations transport creatures from another plane of existence to your plane (calling); create objects or effects on the spot (creation); heal (healing); bring manifestations of objects, creatures, or forms of energy to you (summoning); or transport creatures or objects over great distances (teleportation). Creatures you conjure usually- but not always- obey your commands."
                + "\n\n" +
                "A creature or object brought into being or transported to your location by a conjuration spell cannot appear inside another creature or object, nor can it appear floating in an empty space. It must arrive in an open location on a surface capable of supporting it. The creature or object must appear within the spell’s range, but it does not have to remain within the range.";
        }

        public class Calling : Sub_School
        {
            public Calling()
            {
                Name = "Calling";
                Description = "A calling spell transports a creature from another plane to the plane you are on. The spell grants the creature the one-time ability to return to its plane of origin, although the spell may limit the circumstances under which this is possible. Creatures who are called actually die when they are killed; they do not disappear and reform, as do those brought by a summoning spell (see below). The duration of a calling spell is instantaneous, which means that the called creature can’t be dispelled.";
                Associated_School = new Conjuration();
            }
        }

        public class Creation : Sub_School
        {
            public Creation()
            {
                Name = "Creation";
                Description = "A creation spell manipulates matter to create an object or creature in the place the spellcaster designates. If the spell has a duration other than instantaneous, magic holds the creation together, and when the spell ends, the conjured creature or object vanishes without a trace. If the spell has an instantaneous duration, the created object or creature is merely assembled through magic. It lasts indefinitely and does not depend on magic for its existence.";
                Associated_School = new Conjuration();
            }
        }

        public class Healing : Sub_School
        {
            public Healing()
            {
                Name = "Healing";
                Description = "Certain divine conjurations heal creatures or even bring them back to life.";
                Associated_School = new Conjuration();
            }
        }

        public class Summoning : Sub_School
        {
            public Summoning()
            {
                Name = "Summoning";
                Description = "A summoning spell instantly brings a creature or object to a place you designate. When the spell ends or is dispelled, a summoned creature is instantly sent back to where it came from, but a summoned object is not sent back unless the spell description specifically indicates this. A summoned creature also goes away if it is killed or if its hit points drop to 0 or lower, but it is not really dead. It takes 24 hours for the creature to reform, during which time it can’t be summoned again. When the spell that summoned a creature ends and the creature disappears, all the spells it has cast expire. A summoned creature cannot use any innate summoning abilities it may have.";
                Associated_School = new Conjuration();
            }
        }

        public class Teleportation : Sub_School
        {
            public Teleportation()
            {
                Name = "Teleportation";
                Description = "A teleportation spell transports one or more creatures or objects a great distance. The most powerful of these spells can cross planar boundaries. Unlike summoning spells, the transportation is (unless otherwise noted) one-way and not dispellable. Teleportation is instantaneous travel through the Astral Plane. Anything that blocks astral travel also blocks teleportation.";
                Associated_School = new Conjuration();
            }
        }
    }

    class Divination : Magic_School
    {
        public Divination()
        {
            Name = "Divination";
            Description = "Divination spells enable you to learn secrets long forgotten, predict the future, find hidden things, and foil deceptive spells."
                + "\n\n" +
                "Many divination spells have cone-shaped areas. These move with you and extend in the direction you choose. The cone defines the area that you can sweep each round. If you study the same area for multiple rounds, you can often gain additional information, as noted in the descriptive text for the spell.";
        }

        public class Scrying : Sub_School
        {
            public Scrying()
            {
                Name = "Scrying";
                Description = "a scrying spell creates an invisible magical sensor that sends you information. Unless noted otherwise, the sensor has the same powers of sensory acuity that you possess. This level of acuity includes any spells or effects that target you, but not spells or effects that emanate from you. The sensor, however, is treated as a separate, independent sensory organ of yours, and thus functions normally even if you have been blinded or deafened, or otherwise suffered sensory impairment."
                    + "\n\n" +
                    "A creature can notice the sensor by making a Perception check with a DC 20 + the spell level. The sensor can be dispelled as if it were an active spell."
                    + "\n\n" +
                    "Lead sheeting or magical protection blocks a scrying spell, and you sense that the spell is blocked.";
            }
        }
    }

    class Enchantment : Magic_School
    {
        public Enchantment()
        {
            Name = "Enchantment";
            Description = "Enchantment spells affect the minds of others, influencing or controlling their behavior."
                + "\n\n" +
                "All enchantments are mind-affecting spells. Two subschools of enchantment spells grant you influence over a subject creature.";
        }

        public class Charm : Sub_School
        {
            public Charm()
            {
                Name = "Charm";
                Description = "A charm spell changes how the subject views you, typically making it see you as a good friend.";
                Associated_School = new Enchantment();
            }
        }

        public class Compulsion : Sub_School
        {
            public Compulsion()
            {
                Name = "Compulsion";
                Description = "A compulsion spell forces the subject to act in some manner or changes the way its mind works. Some compulsion spells determine the subject’s actions or the effects on the subject, others allow you to determine the subject’s actions when you cast the spell, and still others give you ongoing control over the subject.";
                Associated_School = new Enchantment();
            }
        }
    }

    class Evocation : Magic_School
    {
        public Evocation()
        {
            Name = "Evocation";
            Description = "Evocation spells manipulate magical energy or tap an unseen source of power to produce a desired end. In effect, an evocation draws upon magic to create something out of nothing. Many of these spells produce spectacular effects, and evocation spells can deal large amounts of damage.";
        }
    }

    class Illusion : Magic_School
    {
        public Illusion()
        {
            Name = "Illusion";
            Description = "Illusion spells deceive the senses or minds of others. They cause people to see things that are not there, not see things that are there, hear phantom noises, or remember things that never happened.";
        }

        public class Figment : Sub_School
        {
            public Figment()
            {
                Name = "Figment";
                Description = "A figment spell creates a false sensation. Those who perceive the figment perceive the same thing, not their own slightly different versions of the figment. It is not a personalized mental impression. Figments cannot make something seem to be something else. A figment that includes audible effects cannot duplicate intelligible speech unless the spell description specifically says it can. If intelligible speech is possible, it must be in a language you can speak. If you try to duplicate a language you cannot speak, the figment produces gibberish. Likewise, you cannot make a visual copy of something unless you know what it looks like (or copy another sense exactly unless you have experienced it)."
                    + "\n\n" +
                    "Because figments and glamers are unreal, they cannot produce real effects the way that other types of illusions can. Figments and glamers cannot cause damage to objects or creatures, support weight, provide nutrition, or provide protection from the elements. Consequently, these spells are useful for confounding foes, but useless for attacking them directly."
                    + "\n\n" +
                    "A figment’s AC is equal to 10 + its size modifier.";
                Associated_School = new Illusion();
            }
        }

        public class Glamer : Sub_School
        {
            public Glamer()
            {
                Name = "Glamer";
                Description = "A glamer spell changes a subject’s sensory qualities, making it look, feel, taste, smell, or sound like something else, or even seem to disappear.";
                Associated_School = new Illusion();
            }
        }

        public class Pattern : Sub_School
        {
            public Pattern()
            {
                Name = "Pattern";
                Description = "Like a figment, a pattern spell creates an image that others can see, but a pattern also affects the minds of those who see it or are caught in it. All patterns are mind-affecting spells.";
                Associated_School = new Illusion();
            }
        }

        public class Phantasm : Sub_School
        {
            public Phantasm()
            {
                Name = "Phantasm";
                Description = "A phantasm spell creates a mental image that usually only the caster and the subject (or subjects) of the spell can perceive. This impression is totally in the minds of the subjects. It is a personalized mental impression, all in their heads and not a fake picture or something that they actually see. Third parties viewing or studying the scene don’t notice the phantasm. All phantasms are mind-affecting spells.";
                Associated_School = new Illusion();
            }
        }

        public class Shadow : Sub_School
        {
            public Shadow()
            {
                Name = "Shadow";
                Description = "A shadow spell creates something that is partially real from extradimensional energy. Such illusions can have real effects. Damage dealt by a shadow illusion is real.";
                Associated_School = new Illusion();
            }
        }
    }

    class Necromancy : Magic_School
    {
        public Necromancy()
        {
            Name = "Necromancy";
            Description = "Necromancy spells manipulate the power of death, unlife, and the life force. Spells involving undead creatures make up a large part of this school.";
        }
    }

    class Transmutation : Magic_School
    {
        public Transmutation()
        {
            Name = "Transmutation";
            Description = "Transmutation spells change the properties of some creature, thing, or condition.";
        }

        public class Polymorph : Sub_School
        {
            public Polymorph()
            {
                Name = "Polymorph";
                Description = "A polymorph spell transforms your physical body to take on the shape of another creature. While these spells make you appear to be the creature, granting you a +10 bonus on Disguise skill checks, they do not grant you all of the abilities and powers of the creature. Each polymorph spell allows you to assume the form of a creature of a specific type, granting you a number of bonuses to your ability scores and a bonus to your natural armor. In addition, each polymorph spell can grant you a number of other benefits, including movement types, resistances, and senses. If the form you choose grants these benefits, or a greater ability of the same type, you gain the listed benefit. If the form grants a lesser ability of the same type, you gain the lesser ability instead. Your base speed changes to match that of the form you assume. If the form grants a swim or burrow speed, you maintain the ability to breathe if you are swimming or burrowing. The DC for any of these abilities equals your DC for the polymorph spell used to change you into that form."
                    + "\n\n" +
                    "In addition to these benefits, you gain any of the natural attacks of the base creature, including proficiency in those attacks. These attacks are based on your base attack bonus, modified by your Strength or Dexterity as appropriate, and use your Strength modifier for determining damage bonuses."
                    + "\n\n" +
                    "If a polymorph spell causes you to change size, apply the size modifiers appropriately, changing your armor class, attack bonus, Combat Maneuver Bonus, and Stealth skill modifiers. Your ability scores are not modified by this change unless noted by the spell."
                    + "\n\n" +
                    "Unless otherwise noted, polymorph spells cannot be used to change into specific individuals. Although many of the fine details can be controlled, your appearance is always that of a generic member of that creature’s type. Polymorph spells cannot be used to assume the form of a creature with a template or an advanced version of a creature."
                    + "\n\n" +
                    "When you cast a polymorph spell that changes you into a creature of the animal, dragon, elemental, magical beast, plant, or vermin type, all of your gear melds into your body. Items that provide constant bonuses and do not need to be activated continue to function while melded in this way (with the exception of armor and shield bonuses, which cease to function). Items that require activation cannot be used while you maintain that form. While in such a form, you cannot cast any spells that require material components (unless you have the Eschew Materials or Natural Spell feat), and can only cast spells with somatic or verbal components if the form you choose has the capability to make such movements or speak, such as a dragon. Other polymorph spells might be subject to this restriction as well, if they change you into a form that is unlike your original form (subject to GM discretion). If your new form does not cause your equipment to meld into your form, the equipment resizes to match your new size."
                    + "\n\n" +
                    "While under the effects of a polymorph spell, you lose all extraordinary and supernatural abilities that depend on your original form (such as keen senses, scent, and darkvision), as well as any natural attacks and movement types possessed by your original form. You also lose any class features that depend upon form, but those that allow you to add features (such as sorcerers that can grow claws) still function. While most of these should be obvious, the GM is the final arbiter of what abilities depend on form and are lost when a new form is assumed. Your new form might restore a number of these abilities if they are possessed by the new form."
                    + "\n\n" +
                    "You can only be affected by one polymorph spell at a time. If a new polymorph spell is cast on you (or you activate a polymorph effect, such as wild shape), you can decide whether or not to allow it to affect you, taking the place of the old spell. In addition, other spells that change your size have no effect on you while you are under the effects of a polymorph spell."
                    + "\n\n" +
                    "If a polymorph spell is cast on a creature that is smaller than Small or larger than Medium, first adjust its ability scores to one of these two sizes using the following table before applying the bonuses granted by the polymorph spell.";
                Associated_School = new Transmutation();
            }
        }
    }
}
