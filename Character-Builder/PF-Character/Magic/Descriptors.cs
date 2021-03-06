﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Magic
{
    class Descriptor
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    class Acid : Descriptor
    {
        public Acid()
        {
            Name = "Acid";
            Description = "Acid effects deal damage with chemical reactions rather than cold, electricity, heat, or vibration. This descriptor includes both actual acids and their chemical opposites, called bases or alkalines (such as ammonia and lye).";
        }
    }

    class Air : Descriptor
    {
        public Air()
        {
            Name = "Air";
            Description = "Spells that create air, manipulate air, or conjure creatures from air-dominant planes or with the air subtype should have the air descriptor.";
        }
    }

    class Chaotic : Descriptor
    {
        public Chaotic()
        {
            Name = "Chaotic";
            Description = "Spells that draw upon the power of true chaos or conjure creatures from chaos-aligned planes or with the chaotic subtype should have the chaos descriptor.";
        }
    }

    class Cold : Descriptor
    {
        public Cold()
        {
            Name = "Cold";
            Description = "Cold effects deal damage by making the target colder, typically by blasting it with supernaturally cooled matter or energy. Cold effects also include those that create ice, sleet, or snow out of nothing. They can cause frostbite, numbness, coordination problems, slowed movement and reactions, stupor, and death.";
        }
    }

    class Curse : Descriptor
    {
        public Curse()
        {
            Name = "Curse";
            Description = "Curses are often permanent effects, and usually cannot be dispelled, but can be removed with a break enchantment, limited wish, miracle, remove curse, or wish.";
        }
    }

    class Darkness : Descriptor
    {
        public Darkness()
        {
            Name = "Darkness";
            Description = "Spells that create darkness or reduce the amount of light should have the darkness descriptor. Giving a spell the darkness descriptor indicates whether a spell like daylight is high enough level to counter or dispel it.";
        }
    }

    class Death : Descriptor
    {
        public Death()
        {
            Name = "Death";
            Description = "Spells with the death descriptor directly attack a creature’s life force to cause immediate death, or to draw on the power of a dead or dying creature. The death ward spell protects against death effects, and some creature types are immune to death effects.";
        }
    }

    class Disease : Descriptor
    {
        public Disease()
        {
            Name = "Disease";
            Description = "Disease effects give the target a disease, which may be an invading organism such as a bacteria or virus, an abnormal internal condition (such as a cancer or mental disorder), or a recurring magical effect that acts like one of the former. Creatures with resistance or immunity to disease apply that resistance to their saving throw and the effects of disease spells.";
        }
    }

    class Draconic : Descriptor
    {
        public Draconic()
        {
            Name = "Draconic";
            Description = "The draconic descriptor is for spells tied closely to dragons that those with draconic blood can cast them almost instinctually. Spells with the draconic descriptor were created by dragons in ages long past, and still resonate within the blood of true dragons to this day."
                + "\n\n" +
                "Creatures of the dragon type with 5 or more racial hit dice can select a draconic spell as a spell known regardless of the class spell list it’s on. Each time such a creature gains an additional racial hit die, it can select a draconic spell in place of an existing spell known of the same or higher spell level.";
        }
    }
    
    class Earth : Descriptor
    {
        public Earth()
        {
            Name = "Earth";
            Description = "Spells that manipulate earth or conjure creatures from earth-dominant planes or with the earth subtype should have the earth descriptor.";
        }
    }

    class Electricity : Descriptor
    {
        public Electricity()
        {
            Name = "Electricity";
            Description = "Electricity effects involve the presence and flow of electrical charge, whether expressed in amperes or volts. Electricity deals damage to creatures by disrupting their biological systems. It deals damage to objects (as well as creatures) by heating the material it passes through, and thus technically many electricity spells could also be treated as fire spells, but for sake of game simplicity, it is better to just let electricity-based spells deal electricity damage. Electricity effects may stun, paralyze, or even kill.";
        }
    }

    class Emotion : Descriptor
    {
        public Emotion()
        {
            Name = "Emotion";
            Description = "Spells with this descriptor create emotions or manipulate the target’s existing emotions. Most emotion spells are enchantments, except for fear spells, which are usually necromancy.";
        }
    }

    class Evil : Descriptor
    {
        public Evil()
        {
            Name = "Evil";
            Description = "Spells that draw upon evil powers or conjure creatures from evil-aligned planes or with the evil subtype should have the evil descriptor.";
        }
    }

    class Fear : Descriptor
    {
        public Fear()
        {
            Name = "Fear";
            Description = "Spells with the fear descriptor create, enhance, or manipulate fear. Most fear spells are necromancy spells, though some are enchantment spells.";
        }
    }

    class Fire : Descriptor
    {
        public Fire()
        {
            Name = "Fire";
            Description = "Fire effects make the target hotter by creating fire, directly heating the target with magic or friction. Lava, steam, and boiling water all deal fire damage. Fire effects can also cause confusion, dizziness, exhaustion, fatigue, nausea, unconsciousness, and death. Spells that manipulate fire or conjure creatures from fire-dominant planes or with the fire subtype should have the fire descriptor.";
        }
    }

    class Force : Descriptor
    {
        public Force()
        {
            Name = "Force";
            Description = "Spells with the force descriptor create or manipulate magical force. Force spells affect incorporeal creatures normally (as if they were corporeal creatures).";
        }
    }

    class Good : Descriptor
    {
        public Good()
        {
            Name = "Good";
            Description = "Spells that draw upon the power of true goodness or conjure creatures from good-aligned planes or with the good subtype should have the good descriptor.";
        }
    }

    class Language_Dependent : Descriptor
    {
        public Language_Dependent()
        {
            Name = "Language-Dependent";
            Description = "A language-dependent spell uses intelligible language as a medium for communication. If the target cannot understand or hear what the caster of a language-dependent spell says, the spell has no effect, even if the target fails its saving throw.";
        }
    }

    class Lawful : Descriptor
    {
        public Lawful()
        {
            Name = "Lawful";
            Description = "Spells that draw upon the power of true law or conjure creatures from law-aligned planes or with the lawful subtype should have the law descriptor.";
        }
    }

    class Light : Descriptor
    {
        public Light()
        {
            Name = "Light";
            Description = "Spells that create significant amounts of light or attack darkness effects should have the light descriptor. Giving a spell the light descriptor indicates whether a spell like darkness is high enough level counter or dispel it.";
        }
    }

    class Meditative : Descriptor //not used
    {
        public Meditative()
        {
            Name = "Meditative";
            Description = "Meditative spells fall into an unusual category and share the “meditative” descriptor. Meditative spells are not cast like other spells—they are cast during the period of the day when a spellcaster prepares her spells. A meditative spell must already be prepared at the time when you start your 1-hour spell preparation ritual, and at the end of that time, the meditative spell of your choosing is cast, leaving you with that one spell slot used for the remainder of the day. You can have only one meditative spell in effect on you at any one time. All meditative spells have a range of personal and a target of you, and they can’t be brewed into potions or part of similar one-use items like elixirs. A meditative spell can be placed on a scroll or in a wand, but the act of casting the spell must always be incorporated into the user’s spell-preparation time; it also takes 1 hour for a character who succeeds at an appropriate Use Magic Device check to operate such an item.";
        }
    }

    class Mind_Affecting : Descriptor
    {
        public Mind_Affecting()
        {
            Name = "Mind-Affecting";
            Description = "Mindless creatures (those with an Intelligence score of “—”) and undead are immune to mind-affecting effects.";
        }
    }

    class Pain : Descriptor
    {
        public Pain()
        {
            Name = "Pain";
            Description = "Pain effects cause unpleasant sensations without any permanent physical damage (though a sensitive target may suffer mental repercussions from lengthy exposure to pain). Creatures that are immune to effects that require a Fort save (such as constructs and undead) are immune to pain effects.";
        }
    }

    class Poison : Descriptor
    {
        public Poison()
        {
            Name = "Poison";
            Description = "oison effects use poison, venom, drugs, or similar toxic substances to disrupt and damage living creatures through chemical reactions. Technically, acids and poisons are both chemical reactions, but for the purpose of this game, they are categorized as different effects, with acids dealing hit point damage and poisons causing ability damage, ability drain, bleeding, confusion, convulsions, nausea, paralysis, reduced healing, suffocation, unconsciousness, or death. Creatures with resistance to poison (such as dwarves) apply that resistance to their saving throws and the effects of poison spells. Creatures with immunity are immune to poisonous aspects of poison spells, but not necessarily all effects of the spell (for example, a spell that creates a pit full of liquid poison could still trap or drown a poison-immune creature).";
        }
    }

    class Ruse : Descriptor //not used
    {
        public Ruse()
        {
            Name = "Ruse";
            Description = "The “ruse” descriptor applies to spells that appear to be other, usually more harmless spells in order for the caster to fool her opponents. Spells with the ruse descriptor are easily mistaken for other spells and are intended to confuse even onlookers trained in Spellcraft or Knowledge (arcana). Attempts to identify a ruse spell by its effects, its aura, its components, or other attributes with a skill check treat the spell as though it were a different spell, as indicated in the spell’s description. The one attempting the check can correctly identify the spell only by exceeding the DC by 10. The false spell is typically a level lower than the ruse spell, so skill checks use the DC for the lower-level spell. Even detect magic and most similar spells don’t prevent the caster from being fooled by a ruse spell. Analyze dweomer, greater arcane sight, and similar spells of the same or higher spell level that automatically identify spells reveal a ruse spell for what it is. Ruse spells that mimic harmless spells still list harmless on their saving throw or spell resistance lines; a creature that knows or suspects the true nature of the spell typically chooses to attempt the save.";
        }
    }

    class Shadow : Descriptor
    {
        public Shadow()
        {
            Name = "Shadow";
            Description = "Shadow spells manipulate matter or energy from the Shadow Plane, or allow transport to or from that plane.";
        }
    }

    class Sonic : Descriptor
    {
        public Sonic()
        {
            Name = "Sonic";
            Description = "Sonic effects transmit energy to the target through frequent oscillations of pressure through the air, water, or ground. Sounds that are too high or too low for the humanoid ear to detect can still transmit enough energy to cause harm, which means that these effects can even affect deafened creatures. Sound effects can cause hit point damage, deafness, dizziness, nausea, pain, shortness of breath, and temporary blindness, and can detect creatures using batlike echolocation.";
        }
    }

    class Water : Descriptor
    {
        public Water()
        {
            Name = "Water";
            Description = "Spells that manipulate water or conjure creatures from water-dominant planes or with the water subtype should have the water descriptor.";
        }
    }
}
