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
    internal class Item
    {
        protected string name;
        protected string description;
        protected double weight;
        protected double value;

        /// <summary>
        /// A constructor for the Item class
        /// </summary>
        /// <param name="name">The name of the item</param>
        /// <param name="description">The description of the item</param>
        /// <param name="weight">The weight value of the item</param>
        /// <param name="value">The monetary value of the item</param>
        public Item(string name, string description, double weight, double value)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;
            this.value = value;
        }

        /// <summary>
        /// Formats the item output when printed to console
        /// </summary>
        /// <returns>The intended readable format for each attribute</returns>
        /// 
        /* So I used @ here to make it a literal, but the only way it still formatted correctly was to have the last three on the far
        * left side. It was ugly as sin. Because of that, I'm using the \n escape, because it's more readable. But I DID know how to
        * do the other one. Maybe you can tell me how it works with a literal that will still be nice looking. */
        public new string ToString => 
            $"Item name: {name}\nDescription: {description}\nWeight: {weight} pounds\nValue: {value} gold pieces";
    }
}
