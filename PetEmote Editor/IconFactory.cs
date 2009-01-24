using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using PetEmote.Core;
using PetEmote.Editor.Graphics;

namespace PetEmote.Editor
{
    class IconFactory
    {
        public Bitmap GetPetFamilyIcon (PetFamilyType familyType)
        {
            switch (familyType)
            {
                case PetFamilyType.Unknown: return IconsWoW.INV_Misc_QuestionMark;
                case PetFamilyType.Bat: return IconsWoW.Ability_Hunter_Pet_Bat;
                case PetFamilyType.Bear: return IconsWoW.Ability_Hunter_Pet_Bear;
                case PetFamilyType.BirdOfPrey: return IconsWoW.Ability_Hunter_Pet_Owl;
                case PetFamilyType.Boar: return IconsWoW.Ability_Hunter_Pet_Boar;
                case PetFamilyType.Cat: return IconsWoW.Ability_Hunter_Pet_Cat;
                case PetFamilyType.Chimera: return IconsWoW.Ability_Hunter_Pet_Chimera;
                case PetFamilyType.CoreHound: return IconsWoW.Ability_Hunter_Pet_CoreHound;
                case PetFamilyType.Crab: return IconsWoW.Ability_Hunter_Pet_Crab;
                case PetFamilyType.Crocolisk: return IconsWoW.Ability_Hunter_Pet_Crocolisk;
                case PetFamilyType.Devilsaur: return IconsWoW.Ability_Hunter_Pet_Devilsaur;
                case PetFamilyType.DragonHawk: return IconsWoW.Ability_Hunter_Pet_DragonHawk;
                case PetFamilyType.Gorilla: return IconsWoW.Ability_Hunter_Pet_Gorilla;
                case PetFamilyType.Hyena: return IconsWoW.Ability_Hunter_Pet_Hyena;
                case PetFamilyType.Moth: return IconsWoW.Ability_Hunter_Pet_Moth;
                case PetFamilyType.NetherRay: return IconsWoW.Ability_Hunter_Pet_NetherRay;
                case PetFamilyType.Raptor: return IconsWoW.Ability_Hunter_Pet_Raptor;
                case PetFamilyType.Ravager: return IconsWoW.Ability_Hunter_Pet_Ravager;
                case PetFamilyType.Rhino: return IconsWoW.Ability_Hunter_Pet_Rhino;
                case PetFamilyType.Scorpid: return IconsWoW.Ability_Hunter_Pet_Scorpid;
                case PetFamilyType.Serpent: return IconsWoW.Spell_Nature_GuardianWard;
                case PetFamilyType.Silithid: return IconsWoW.Ability_Hunter_Pet_Silithid;
                case PetFamilyType.Spider: return IconsWoW.Ability_Hunter_Pet_Spider;
                case PetFamilyType.Sporebat: return IconsWoW.Ability_Hunter_Pet_Sporebat;
                case PetFamilyType.TallStrider: return IconsWoW.Ability_Hunter_Pet_TallStrider;
                case PetFamilyType.Turtle: return IconsWoW.Ability_Hunter_Pet_Turtle;
                case PetFamilyType.Vulture: return IconsWoW.Ability_Hunter_Pet_Vulture;
                case PetFamilyType.WarpStalker: return IconsWoW.Ability_Hunter_Pet_WarpStalker;
                case PetFamilyType.Wasp: return IconsWoW.Ability_Hunter_Pet_Wasp;
                case PetFamilyType.WindSerpent: return IconsWoW.Ability_Hunter_Pet_WindSerpent;
                case PetFamilyType.Wolf: return IconsWoW.Ability_Hunter_Pet_Wolf;
                case PetFamilyType.Worm: return IconsWoW.Ability_Hunter_Pet_Worm;

                case PetFamilyType.FelGuard: return IconsWoW.Spell_Shadow_SummonFelGuard;
                case PetFamilyType.FelHunter: return IconsWoW.Spell_Shadow_SummonFelHunter;
                case PetFamilyType.Imp: return IconsWoW.Spell_Shadow_SummonImp;
                case PetFamilyType.Infernal: return IconsWoW.Spell_Shadow_SummonInfernal;
                case PetFamilyType.Succubus: return IconsWoW.Spell_Shadow_SummonSuccubus;
                case PetFamilyType.VoidWalker: return IconsWoW.Spell_Shadow_SummonVoidWalker;

                case PetFamilyType.Ghoul: return IconsWoW.Spell_DeathKnight_Gnaw_Ghoul;

                default: return IconsWoW.INV_Misc_QuestionMark;
            }
        }

        public Bitmap GetClassIcon (PetClassType classType)
        {
            switch (classType)
            {
                case PetClassType.Unknown: return IconsWoW.INV_Misc_QuestionMark;
                case PetClassType.DeathKnight: return IconsWoW.Spell_Deathknight_ClassIcon;
                case PetClassType.Hunter: return IconsWoW.INV_Weapon_Bow_07;
                case PetClassType.Warlock: return IconsWoW.Spell_Nature_Drowsy;
                default: return IconsWoW.INV_Misc_QuestionMark;
            }
        }
    }
}
