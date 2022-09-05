///////////////////////////////////////////////////////////////////////////////
//
// Author: Chris Boyle, boylec1@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1
// Description: Converting a Java program to C#
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class Backpack
    {
        private List<Item> contents;

        /// <summary>
        /// A constructor that creates a new List for contents
        /// </summary>
        public Backpack()
        {
            contents = new List<Item>();
        }

        /// <summary>
        /// Adds a specified item to the backpack List
        /// </summary>
        /// <param name="item">An Item specified by the call</param>
        public void Add(Item item)
        {
            contents.Add(item);
        }

        /// <summary>
        /// Checks the backpack for Weapons, and if they exist, adds them to a string. Returns the string at the end.
        /// </summary>
        /// <returns>Returns the gathered list of Weapons</returns>
        public string ListWeapons()
        {
            /* Same here with these as in Items. The @ literal works, but the multiline to make it format properly is so bad looking \
             * I couldn't stand it. Hence the \n escape characters here and further down. Also it processes much faster, so that seems
             * like a good added bonus. */
            string weapons = "";
            weapons += "Weapons--------------------------------------------------\n";
            foreach(Item i in contents)
            {
                if(i is Weapon)
                {
                    weapons += i.ToString;
                    weapons += "\n---------------------------------------------------------\n";
                }
            }
            return weapons;
        }

        /// <summary>
        /// Checks the backpack for Clues, and if they exist, adds them to a string. Returns the string at the end.
        /// </summary>
        /// <returns>Returns the gathered list of Clues</returns>
        public string ListClues()
        {
            string clues = "";
            clues += "Clues----------------------------------------------------\n";
            foreach(Item i in contents)
            {
                if(i is Clue)
                {
                    clues += i.ToString;
                    clues += "\n---------------------------------------------------------\n";
                }
            }
            return clues;
        }

        /// <summary>
        /// Checks the backpack for Consumables, and if they exist, adds them to a string. Returns the string at the end.
        /// </summary>
        /// <returns>Returns the gathered list of Consumables</returns>
        public string ListConsumables()
        {
            string consumables = "";
            consumables += "Consumables----------------------------------------------\n";
            foreach(Item i in contents)
            {
                if(i is Consumable)
                {
                    consumables += i.ToString;
                    consumables += "\n---------------------------------------------------------\n";
                }
            }
            return consumables;
        }
    }
}