using System;

namespace Human2
{ 
    //Fields of Human 
    class Human {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity; 
        private int health; 
        // add a public "getter" property to access health
        public int Health
        {
            get{ return this.health; }
            
        }

        // Add a constructor method that takes a string to initialize Name- and that will initialize Strength, Intelligence, and Dexterirty to a default value of 3, and health to default value of 100 
        public Human (string name)
        {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3; 
            this.Dexterity = 3;
            this.health = 100;
        }
        // Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human (string name, int strength, int intelligence, int dexterity, int health)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;            
            this.health = health; 
        }
       

        // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.

         public int Attack ()
        {
            this.health -= ( 5 * this.Strength);
            return Health;
        }
    }
}