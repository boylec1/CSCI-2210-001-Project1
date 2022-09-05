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
    internal class Weapon : Clue
    {
        private int damage;
        private DamageType damageType;

        /// <summary>
        /// A constructor for the Weapon class
        /// </summary>
        /// <param name="name">The name of the weapon</param>
        /// <param name="description">The description of the weapon</param>
        /// <param name="weight">The weight value of the weapon</param>
        /// <param name="value">The monetary value of the weapon</param>
        public Weapon(string name, string description, double weight, double value)
            : base(name, description, weight, value)
        {
        }

    }
}
