using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var charlie = new Bird();
            charlie.color = "White & Brown";
            charlie.legNumber = 2;
            charlie.weight = 1.4;
            charlie.tail = true;
            charlie.wingSpan = 35; 
            charlie.beakColor = "White";
            charlie.canTalk = false;
            charlie.species = "Tawny Owl";
            
            Console.WriteLine($"Here's our first bird, Charlie!\n" +
                              $"Charlie is a {charlie.species} that is {charlie.color} with a {charlie.beakColor} beak.\n" + 
                              $"Charlie has {charlie.legNumber} legs, weighs {charlie.weight} lbs. and has a {charlie.wingSpan} in. wingspan!\n" + 
                              $"True or False: Charlie has a tail? {charlie.tail}\n" + 
                              $"True or False: Charlie can talk? {charlie.canTalk}, but he can hoot!");

            /*
             * Creatively display the class member values
             */

            var henrietta = new Reptile();
            henrietta.color = "Light Brown";
            henrietta.legNumber = 4;
            henrietta.weight = 0.6;
            henrietta.tail = true;
            henrietta.length = 4.2;
            henrietta.poisonous = false;
            henrietta.howScary = 3;
            henrietta.species = "Armadillo Girdled Lizard";
            
            Console.WriteLine($"\nHere's our first Reptile, Henrietta!\n" +
                              $"Henrietta is an {henrietta.species} that is {henrietta.color} and has {henrietta.legNumber} legs.\n" +
                              $"Henrietta weighs {henrietta.weight} lbs. and is {henrietta.length} in. long. On the scariness scale from 1-10, Henrietta's tough skin make her a {henrietta.howScary}.\n" + 
                              $"True or False: Henrietta has a tail? {henrietta.tail}\n" +
                              $"True or False: Henrietta is posionous? {henrietta.poisonous}\n");
        }
    }
}
