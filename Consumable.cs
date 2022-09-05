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

    internal class Consumable : Item
    {
        private int healthEffect;
        private int dosesRemaining;

        /// <summary>
        /// A constructor for the Consumable class
        /// </summary>
        /// <param name="name">Name of the consumable</param>
        /// <param name="description">A description of the consumable</param>
        /// <param name="weight">The weight value of the consumable</param>
        /// <param name="value">The monetary value of the consumable</param>
        public Consumable(String name, String description, double weight, double value)
            : base(name, description, weight, value)
        {
        }

    }
}
