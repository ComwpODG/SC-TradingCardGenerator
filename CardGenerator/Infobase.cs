using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGenerator
{
    public static class Infobase
    {
        public static List<ShipPair> Ships = new List<ShipPair>()
        {
            new ShipPair("100px-Achilles.png","Achilles","Empire","9","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Acid_Hydra.png","Acid Hydra","Empire","7","Frigate","ELRF","Silver","Credits"),
            new ShipPair("100px-Alligator-C.png","Alligator C","Federation","5","Frigate","Guard","Silver","Credits"),
            new ShipPair("100px-Alligator-M.png","Alligator M","Federation","6","Frigate","Engineer","Silver","Credits"),
            new ShipPair("100px-Alligator_Mk_II.png","Alligator Mk II","Federation","7","Frigate","Engineer","Silver","Credits"),
            new ShipPair("100px-Anaconda-M.png","Anaconda M","Federation","9","Frigate","Guard","Silver","Credits"),
            new ShipPair("100px-Anaconda.png","Anaconda","Federation","8","Frigate","Engineer","Silver","Credits"),
            new ShipPair("100px-Anaconda_Mk_II.png","Anaconda Mk II","Federation","10","Frigate","Engineer","Silver","Credits"),
            new ShipPair("100px-Apollo.png","Apollo","Empire","13","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Archdragon.png","Archdragon","Empire","15","Frigate","ELRF","Silver","Credits"),
            new ShipPair("100px-Archelon.png","Archelon","Federation","7","Frigate","Guard","Gold","Components"),
            new ShipPair("100px-Argonaut.png","Argonaut","Empire","12","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Atlas.png","Atlas","Empire","12","Frigate","ELRF","Gold","GS"),
            new ShipPair("100px-Aura.png","Aura","Empire","14","Fighter","Command","Silver","Credits"),
            new ShipPair("100px-Axe-X.png","Axe X","Jericho","3","Fighter","Command","Silver","Credits"),
            new ShipPair("100px-Axe-XS.png","Axe XS","Jericho","2","Fighter","Command","Gold Silver","Discontinued"),
            new ShipPair("100px-Axe.png","Axe","Jericho","1","Fighter","Command","Silver","Credits"),
            new ShipPair("100px-Bear.png","Bear","Federation","16","Fighter","Tackler","Gold","DLC"),
            new ShipPair("100px-Berserker.png","Berserker","Empire","15","Interceptor","Recon","Gold","GS"),
            new ShipPair("100px-Black_Bomber.png","Black Bomber","Federation","10","Interceptor","Recon","Silver","Credits"),
            new ShipPair("100px-Black_Death.png","Black Death","Jericho","3","Interceptor","ECM","Gold","GS"),
            new ShipPair("100px-Black_Dragon.png","Black Dragon","Empire","15","Frigate","ELRF","Gold","GS"),
            new ShipPair("100px-Black_Hort.png","Black Hort","Jericho","3","Fighter","Command","Gold","GS"),
            new ShipPair("100px-Black_Swarm.png","Black Swarm","Empire","9","Interceptor","ECM","Silver","Credits"),
            new ShipPair("100px-Blade_of_Aressa.png","Blade of Aressa","Federation","6","Interceptor","Covert Ops","Gold","GS"),
            new ShipPair("100px-Blood_Tormentor.png","Blood Tormentor","Jericho","16","Frigate","Guard","Gold","DLC"),
            new ShipPair("100px-Boremys.png","Boremys","Federation","17","Frigate","Guard","Gold","Components"),
            new ShipPair("100px-Brokk.png","Brokk","Empire","13","Frigate","Engineer","Gold","Components"),
            new ShipPair("100px-Caltrop.png","Caltrop","Jericho","15","Interceptor","ECM","Purple","Standard Ship Components"),
            new ShipPair("100px-Castor.png","Castor","Empire","11","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Centaur.png","Centaur","Empire","11","Frigate","ELRF","Silver","Credits"),
            new ShipPair("100px-Cerberus.png","Cerberus","Empire","9","Frigate","ELRF","Silver","Credits"),
            new ShipPair("100px-Chiron.png","Chiron","Empire","12","Frigate","ELRF","Silver","Credits"),
            new ShipPair("100px-Crusader.png","Crusader","Jericho","8","Frigate","Guard","Silver","Credits"),
            new ShipPair("100px-Crus_A.png","Crus A","Jericho","9","Frigate","JLRF","Gold","GS"),
            new ShipPair("100px-Crus_Q.png","Crus Q","Jericho","6","Frigate","JLRF","Gold","GS"),
            new ShipPair("100px-Crus_S.png","Crus S","Jericho","9","Frigate","Guard","Silver","GS"),
            new ShipPair("100px-Custodian.png","Custodian","Jericho","17","Frigate","Guard","Purple","Unique Ship Components"),
            new ShipPair("100px-Cutter.png","Cutter","Jericho","12","Interceptor","Covert Ops","Gold","DLC"),
            new ShipPair("100px-Cyning.png","Cyning","Empire","15","Interceptor","Recon","Purple","Standard Ship Components"),
            new ShipPair("100px-Dagger.png","Dagger","Jericho","3","Interceptor","ECM","Silver","Credits"),
            new ShipPair("100px-Dagger_AE.png","Dagger AE","Jericho","4","Interceptor","ECM","Silver","Credits"),
            new ShipPair("100px-Dagger_V.png","Dagger V","Jericho","5","Interceptor","Covert Ops","Silver","Credits"),
            new ShipPair("100px-Dainsleif.png","Dainsleif","Empire","3","Fighter","Gunship","Gold","DLC"),
            new ShipPair("100px-Dart.png","Dart","Jericho","11","Fighter","Command","Purple","Unique Ship Components"),
            new ShipPair("100px-Deimon.png","Deimon","Empire","9","Interceptor","Recon","Gold","GS"),
            new ShipPair("100px-Deimos.png","Deimos","Empire","5","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Deimos_2.png","Deimos 2","Empire","6","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Desert_Eagle.png","Desert Eagle","Empire","9","Fighter","Gunship","Gold","DLC"),
            new ShipPair("100px-Diamond_Dwarf.png","Diamond Dwarf","Empire","7","Interceptor","Recon","Silver","Credits"),
            new ShipPair("100px-Dragon.png","Dragon","Empire","13","Frigate","ELRF","Silver","Credits"),
            new ShipPair("100px-Dyrnwyn.png","Dyrnwyn","Empire","17","Interceptor","ECM","Purple","Unique Ship Components"),
            new ShipPair("100px-Granite.png","Granite","Empire","16","Fighter","Command","Purple","StandardShip Components"),
            new ShipPair("100px-Gungnir.png","Gungnir","Empire","16","Frigate","ELRF","Purple","Unique Ship Components"),
            new ShipPair("100px-Hammerhead.png","Hammerhead","Federation","17","Frigate","Engineer","Purple","Unique Ship Components"),
            new ShipPair("100px-Project_1011.png","Project 1011","Empire","17","Frigate","ELRF","Purple","Unique Ship Components"),
            new ShipPair("100px-Kusarigama.png","Kusarigama","Jericho","16","Interceptor","Covert Ops","Purple","Standard Ship Components"),
            new ShipPair("100px-Irbis.png","Irbis","Federation","17","Fighter","Tackler","Purple","Unique Ship Components"),
            new ShipPair("100px-Kirishima.png","Kirishima","Jericho","17","Fighter","Command","Purple","Unique Ship Components"),
            new ShipPair("100px-Singularity_(ship).png","Singularity","Jericho","16","Fighter","Tackler","Purple","Standard Ship Components"),
            new ShipPair("100px-Spark.png","Spark","Empire","15","Fighter","Gunship","Gold","GS"),
            new ShipPair("100px-Spectre_Falcon.png","Spectre Falcon","Federation","14","Interceptor","Recon","Silver","Credits"),
            new ShipPair("100px-Spike.png","Spike","Federation","17","Interceptor","Covert Ops","Purple","Standard Ship Components"),
            new ShipPair("100px-Kite.png","Kite","Federation","9","Interceptor","Covert Ops","Silver","Credits"),
            new ShipPair("100px-Konkistador.png","Konkistador","Federation","12","Interceptor","Covert Ops","Gold","GS"),
            new ShipPair("100px-Kraken.png","Kraken","Empire","15","Frigate","ELRF","Purple","Standard Ship Components"),
            new ShipPair("100px-Kris.png","Kris","Jericho","8","Interceptor","ECM","Silver","Credits"),
            new ShipPair("100px-Wolf-M.png","Wolf M","Federation","9","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Wolf.png","Wolf","Federation","8","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Peregrine.png","Peregrine","Federation","15","Interceptor","Covert Ops","Purple","Standard Ship Components"),
            new ShipPair("100px-Piranha-B2.png","Piranha B2","Federation","14","Fighter","Gunship","Silver","Credits"),
            new ShipPair("100px-Razor.png","Razor","Jericho","15","Fighter","Tackler","Gold","DLC"),
            new ShipPair("100px-Scimitar.png","Scimitar","Jericho","12","Frigate","Guard","Gold","GS"),
            new ShipPair("100px-Templar.png","Templar","Jericho","6","Frigate","JLRF","Silver","Credits")
        };

        public static List<PlayerDesc> Playerbase = new List<PlayerDesc>()
        {
            new PlayerDesc("LadyHina","LadyHina:\n"+
                "\nActive \""+
                "Bullet Attractor\" (3en):\nForce all enemies that are capable of shooting this card with their main weapons to do so on their next turn. While active, allies within 500 units of this card also succumb to the effect, causing friendly fire."),
            new PlayerDesc("Bionuclear","Bionuclear:\n"+
                "\nPassive \""+
                "Backstab\":\nIf there is an ally on the other side of this card's target, main weapons deal +1 damage."),
            new PlayerDesc("Avenger121","Avenger121:\n"+
                "\nPassive \""+
                "Backstab\":\nIf there is an ally on the other side of this card's target, main weapons deal +1 damage."),


            new PlayerDesc("Ephox","Ephox:\n\n"+
                "Passive \""+
                "Sturdy Shields\":\n+1 shield.\n\n"+
                "Passive \""+
                "Sturdy Hull\":\n+1 Hull."),
            new PlayerDesc("DerpNukem","DerpNukem:\n\n"+
                "Passive \""+
                "Sturdy Shields\":\n+1 shield.\n\n"+
                "Passive \""+
                "Sturdy Hull\":\n+1 Hull."),

            new PlayerDesc("PygmyFox","PygmyFox:\n\n"+
                "Passive \""+
                "Convenient Positioning\":\nThis card can choose to move itself an additional 20% of its base speed once per turn as an undeclared reaction to any enemy action"),

            new PlayerDesc("CytochromeP450","CytochromeP450:\n\n"+
                "Passive \""+
                "Convenient Positioning\":\nThis card can choose to move itself an additional 20% of its base speed once per turn as an undeclared reaction to any enemy action\n\n"+
                "Active \""+
                "Elemental Proficiency\" (1en):\nForces the best outcome of elemental dice."),

            //You would put your definitions in here

            new PlayerDesc("PapyMcBites","PapyMcBites:\n\n"+
                "Passive \""+
                "I'm The Best, I'm The Worst\":\n At the start of each turn, roll a d2. On 2, all checks made by this card (targeting, elemental damage, etc) are now mae with advantage. On a 1, with disadvantage."),

            new PlayerDesc("Coffeezone","Coffeezone:\n\n"+
                "Active \""+
                "I'm Going To Get Milk\" (3en):\n Flip this card over for 1 turn. It cannot use any actions, nor is it part of the game, for this turn*. Good for staying alive under heavy fire if you just need to buy time. *Does not count as a map obstacle either.")

        };

    }

    public class PlayerDesc
    {
        public PlayerDesc(string n, string s)
        {
            PlayerName = n;
            PlayerStats = s;
        }

        public string PlayerName { get; set; }
        public string PlayerStats { get; set; }

    }

    public class ShipPair
    {
        public ShipPair(string i, string s)
        {
            ImageFileName = i;
            ShipName = s;
            Faction = "Federation";
        }

        public ShipPair(string i, string s, string f)
        {
            ImageFileName = i;
            ShipName = s;
            Faction = f;
        }

        public ShipPair(string i, string s, string f, string r, string c, string ro, string ra, string cu)
        {
            ImageFileName = i;
            ShipName = s;
            Faction = f;
            Rank = r;
            Class = c;
            Role = ro;
            Rarity = ra;
            Currency = cu;
        }

        public string ImageFileName { get; set; }
        public string ShipName { get; set; }
        public string Faction { get; set; }
        public string Rank { get; set; }
        public string Class { get; set; }
        public string Role { get; set; }
        public string Rarity { get; set; }
        public string Currency { get; set; }

        public string Health
        {
            get
            {
                int Hu = 0;

                if (Class == "Interceptor")
                {
                    Hu += 1;
                }
                if (Class == "Fighter")
                {
                    Hu += 2;
                }
                else if (Class == "Frigate")
                {
                    Hu += 3;
                }
                else if (Class == "Destroyer")
                {
                    Hu += 4;
                }

                if (Role.Contains("LRF"))
                {
                    Hu -= 1;
                }
                else if (Role == "Guard")
                {
                    Hu += 1;
                }

                if (Faction == "Empire")
                {
                    Hu = (int)Math.Ceiling(Hu * 1.3);
                }
                else if (Faction == "Jericho")
                {
                    Hu = (int)Math.Floor(Hu * 0.64);
                }

                Hu += (int)Math.Ceiling(Convert.ToInt32(Rank) / 5.0);

                return ""+Hu;
            }
        }

        public string Shield
        {
            get
            {
                int Sh = 0;

                if (Class == "Interceptor")
                {
                    Sh += 1;
                }
                if (Class == "Fighter")
                {
                    Sh += 2;
                }
                else if(Class == "Frigate")
                {
                    Sh += 3;
                }
                else if(Class == "Destroyer")
                {
                    Sh += 4;
                }

                if(Role.Contains("LRF"))
                {
                    Sh -= 1;
                }
                else if(Role == "Guard")
                {
                    Sh += 1;
                }

                if(Faction == "Empire")
                {
                    Sh = (int)Math.Floor(Sh * 0.64);
                }
                else if(Faction == "Jericho")
                {
                    Sh = (int)Math.Ceiling(Sh * 1.3);
                }

                Sh += (int)Math.Ceiling(Convert.ToInt32(Rank) / 5.0);

                return ""+Sh;
            }
        }

        public string Speed
        {
            get
            {
                int Sp = 600;

                if(Class == "Interceptor")
                {
                    Sp += 400;
                }
                if(Class == "Fighter")
                {

                }
                if(Class == "Frigate")
                {
                    Sp -= 200;
                }
                if (Class == "Destroyer")
                {
                    Sp -= 400;
                }

                if(Faction == "Federation")
                {
                    Sp += 100;
                }
                if (Faction == "Empire")
                {
                    Sp -= 100;
                }


                Sp += 100*((int)Math.Ceiling(Convert.ToInt32(Rank) / 5.0)-2);

                Sp *= 2;

                return "" + Sp;
            }
        }

        public string Evasion
        {
            get
            {
                int Ev = 20;

                if (Class == "Interceptor")
                {
                    Ev += 4;
                }
                if (Class == "Fighter")
                {

                }
                if (Class == "Frigate")
                {
                    Ev -= 5;
                }
                if (Class == "Destroyer")
                {
                    Ev -= 9;
                }

                if (Faction == "Federation")
                {
                    Ev += 3;
                }
                if (Faction == "Empire")
                {
                    Ev += 1;
                }
                if (Faction == "Jericho")
                {
                    Ev -= 1;
                }
                if(Role == "Guard")
                {
                    Ev -= 4;
                }


                Ev += 1 * ((int)Math.Ceiling(Convert.ToInt32(Rank) / 5.0) - 2);

                return "" + Ev;
            }
        }

        public string Range
        {
            get
            {
                int Ra = 2000;

                if (Class == "Interceptor")
                {
                    Ra += 800;
                }
                if (Class == "Fighter")
                {
                    Ra += 1000;
                }
                if (Class == "Frigate")
                {
                    Ra += 1200;
                }
                if (Class == "Destroyer")
                {
                    Ra += 3000;
                }

                
                if (Role.Contains("LRF") || Role == "Recon")
                {
                    Ra = (int)(Ra * 0.8);
                }

                Ra += 100 * ((int)Math.Ceiling(Convert.ToInt32(Rank) / 5.0));

                return "" + Ra;
            }
        }

        public string Targeting
        {
            get
            {
                int Ta = 10;

                if (Class == "Interceptor")
                {
                    Ta += 4;
                }
                if (Class == "Fighter")
                {

                }
                if (Class == "Frigate")
                {
                    Ta += 1;
                }
                if (Class == "Destroyer")
                {
                    Ta -= 2;
                }

                if (Faction == "Federation")
                {
                    Ta -= 0;
                }
                if (Faction == "Empire")
                {
                    Ta += 2;
                }
                if (Faction == "Jericho")
                {
                    Ta += 1;
                }


                if (Role == "Guard")
                {
                    Ta -= 1;
                }
                if (Role.Contains("LRF"))
                {
                    Ta += 2;
                }


                Ta += 1 * ((int)Math.Ceiling(Convert.ToInt32(Rank) / 5.0));

                return "" + Ta;
            }
        }

        public string ShipDescription
        {
            get
            {
                string desc = "";
                desc += Faction + " Rank " + Rank + " " + Role + "\n" +
                    "Gun GUNSTATSHERE\n\n";

                if(Role=="Recon")
                {
                    desc += "Ability \"Microwarp\"(5en):\n" +
                        "Warp the ship up to 8000 units in one direction, requires LOS.\n\n";

                    desc += "Ability \"Mine\"(3en):\n" +
                        "Place a Recon Mine card within movement speed.\n\n";
                }

                if (Role == "ECM")
                {
                    if (Convert.ToInt32(Rank) > 9)
                    {
                        if (Faction == "Empire")
                        {
                            desc += "Ability \"Repair Sabotage\"(4en):\n" +
                            "Stop enemies in weapon range from regenerating for 1 turn.\n\n";
                        }

                        if (Faction == "Jericho")
                        {
                            desc += "Ability \"Moriarty Virus\"(5en):\n" +
                            "Choose one enemy in weapon range. After successfully targeting them, they must target one of their allies with their next main weapon action.\n\n";
                        }
                    }
                    desc += "Ability \"Ion Diffuser\"(4en):\n" +
                        "Stop the target within weapon range from shooting or using abilities for 1 turn. Requires successfull targeting check.\n\n";

                    if (Convert.ToInt32(Rank) > 6)
                    {
                        desc += "Ability \"Energy Steal\"(6en):\n" +
                        "Steals 3 energy of choice from the target within weapon range.\n\n";
                    }
                }

                if (Role == "Covert Ops")
                {
                    if (Convert.ToInt32(Rank) > 6)
                    {
                        if (Faction == "Federation")
                        {
                            desc += "Ability \"Radar Cloak\"(3en):\n" +
                            "The ship card is replaced with 4 Potential Location cards, 2 turn duration.\n\n";
                        }

                        if (Faction == "Jericho")
                        {
                            desc += "Ability \"Quantum Defense\"(3en):\n" +
                            "This card cannot be hit by attacks, OR attack, for 1 turn.\n\n";
                        }
                    }

                    desc += "Ability \"Orion\" (4en):\n" +
                        "Doubles all outgoing damage this turn.\n\n";
                    
                    if (Convert.ToInt32(Rank) > 9)
                    {
                        desc += "Ability \"Nuke\" (3en):\n" +
                        "Place a Covert Ops Nuke card within movement speed.\n\n";
                    }
                }






                if (Role == "Tackler")
                {
                    desc += "Ability \"Tackle Beam\" (1en):\n" +
                        "Slow down an enemy within 5000 units by 100 units. Broken by cloaks and LOS.\n\n";

                    desc += "Ability \"Target Paint\" (2en):\n" +
                        "All damage dealt to a selected target is increased by 1. Broken by cloaks and LOS.\n\n";
                }

                if (Role == "Gunship")
                {
                    desc += "Ability \"Overdrive\" (3en):\n" +
                        "The ship takes 2 shoot actions, 2 move actions, and 2 regen actions this turn.\n\n";

                    desc += "Ability \"Aiming overcharge\" (2en):\n" +
                        "The ship can crit on 10's and higher, for 1 turn.\n\n";
                }

                if (Role == "Command")
                {
                    desc += "Ability \"Diffusion Shield\" (0en):\n" +
                        "The ship takes 1 damage to it's energy bar for each damage received, however, all elements are super-effective against diffusion shield.\n\n";

                    desc += "Ability \"Bolster Defenses\" (2en):\n" +
                        "The ship can block 1 damage of an incoming attack, up to 2 times per activation, for allies in movement speed. Bolster Defenses' Buff to negate damage can be used once per incoming attack, unless that attack hits multiple ships.\n\n";

                    if (Faction == "Jericho")
                    {
                        desc += "Ability \"Gravi-Scanner\" (4en):\n" +
                            "Increases the speed of ships within movement speed by 500 for their upcoming move action, and 700 for the host ship. (does not stack with multiple activations)\n\n";
                    }

                    if (Faction == "Empire")
                    {
                        desc += "Ability \"Valkyrie\" (4en):\n" +
                            "All allies within movement speed deal 1 extra damage with their main weapon on their upcoming shoot action, 2 extra damage for the host ship. (does not stack with multiple activations)\n\n";
                    }

                }

                if (Role == "Engineer")
                {
                    if(Faction == "Federation")
                    {
                        desc += "Ability \"Warp Gate\" (5en):\n" +
                        "Deploys a Warp Gate on the field in movement speed.\n\n";

                        desc += "Ability \"Shield Regeneration Aura\" (1en):\n" +
                        "Allies in movement speed gain 1 shield regeneration.\n\n";
                    }

                    if (Faction == "Empire")
                    {
                        desc += "Ability \"Static Barrier\" (3en):\n" +
                        "Deploys a Static Barrier card on the field in movement speed.\n\n";

                        desc += "Ability \"Hull Regeneration Aura\" (2en):\n" +
                        "Allies in movement speed gain 1 hull regeneration.\n\n";
                    }

                    desc += "Passive \"Energy Recuperation\":\n" +
                        "The ship can regenerate energy during combat at a 100% chance.\n\n";

                }

                if (Role == "Guard")
                {
                    if (Faction == "Federation")
                    {
                        desc += "Ability \"Energy Supply Beam\" (1en):\n" +
                        "An ally in 3000 units and LOS gains 1 energy.\n\n";
                    }

                    if (Faction == "Jericho")
                    {
                        desc += "Reaction Ability \"Defender\" (3en):\n" +
                        "When used while taking damage: 50% chance to negate damage\n\n";
                    }

                    desc += "Ability \"Pulsar\" (2en):\n" +
                        "All enemies in 2000 units take 1 thermal damage.\n\n";

                    desc += "Ability \"Emergency Shield Charge\" (4en):\n" +
                        "The ship regenerates 2 shield.\n\n";
                }

                if (Role.Contains("LRF"))
                {
                    if (Convert.ToInt32(Rank) >= 6)
                    {
                        if (Faction == "Empire")
                        {
                            desc += "Ability \"Disintegrator\"(2en):\n" +
                        "Roll targeting for 3 damage against any enemy within 12000 units. Cannot be used same turn as weapons. While using, movement speed must remain at 0.\n\n";
                        }

                        if (Faction == "Jericho")
                        {
                            desc += "Ability \"Guided Torpedo\"(4en):\n" +
                            "Launch a guided torpedo card at the ship's position in a direction of choice.\n\n";
                        }
                    }

                    desc += "Ability \"EM Scattering Field\"(1en):\n" +
                        "Ships outside of 5000 units have a -5 to hit penalty.\n\n";

                    if (Convert.ToInt32(Rank) >= 9)
                    {
                        desc += "Ability \"Reverse Thruster\"(4en):\n" +
                        "Moves the ship 2500 units away from the nearest enemy.\n\n";
                    }
                }


                return desc;
            }
        }

    }

}