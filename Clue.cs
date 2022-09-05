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
    internal class Clue : Item
    {
        private string personIncriminated;
        private bool accuracy;

        /// <summary>
        /// A constructor for the Clue class
        /// </summary>
        /// <param name="name">The name of the clue</param>
        /// <param name="description">The description of the clue</param>
        /// <param name="weight">The weight value of the clue</param>
        /// <param name="value">The monetary value of the clue</param>
        public Clue(string name, string description, double weight, double value) 
            : base(name, description, weight, value)
        {
        }
    }
}
