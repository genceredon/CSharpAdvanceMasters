using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Reflections
{
    public class ReflectionUseCase
    {
        public ReflectionUseCase()
        {
            Fire fire = new();
            Water water = new();

            Skill skill = new(water);
            skill.UseMove();

            skill.CustomSkill();
        }
    }

    public enum EnumPokemonType
    {
        Fire,
        Water,
        Grass,
        Rock
    }

    public interface IPokemon
    {
        public EnumPokemonType PokemonType { get; }
        public void Eat() { }
    }

    public abstract class Pokemon : IPokemon
    {
        public abstract EnumPokemonType PokemonType { get; }
        public void Eat()
        {
            Console.WriteLine("Pokemon is eating");
        }
    }

    [FireStone]
    public class Fire : Pokemon
    {
        public override EnumPokemonType PokemonType { get { return EnumPokemonType.Fire; } }

        public void Ember()
        {
            Console.WriteLine("Used Ember!!");
        }
    }

    [TechnicalMachine("14")]
    public class Water : Pokemon
    {
        public override EnumPokemonType PokemonType { get { return EnumPokemonType.Water; } }

        public void Surf()
        {
            Console.WriteLine("Used Surf!!");
        }
    }

    //Composition class
    public class Skill
    {
        IPokemon _Pokemon;

        public Skill(IPokemon pokemon)
        {
            _Pokemon = pokemon;
        }

        public void UseMove()
        {
            // Step 1
            // Get the type of the Object
            var PokemonType = _Pokemon.GetType();

            //Console.WriteLine(PokemonType.Name);
            //Console.WriteLine(PokemonType.FullName);

            // Step 2 Browse the Metadata of the Object
            MethodInfo EmberMethodInfo = PokemonType.GetMethod("Ember");

            if (EmberMethodInfo == null )
            {
                _Pokemon.Eat();
            }
            else
            {
                // Step 3 Dynamic invoke
                object EmberAnimaInstance = Activator.CreateInstance(PokemonType);
                EmberMethodInfo.Invoke(EmberAnimaInstance, null);
            }
        }

        public void CustomSkill()
        {
            var PokemonType = _Pokemon.GetType();

            // Custom attribute
            foreach (Attribute stone in PokemonType.GetCustomAttributes())
            {
                if (stone is FireStone)
                {
                    Console.WriteLine("Used Fire Blast!!");
                }
            }

            // Parameterized attribute
            if (PokemonType.GetCustomAttribute<TechnicalMachine>()?.TM == "14")
            {
                Console.WriteLine("Used Blizzard!!");
            }

        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class FireStone: Attribute
    {

    }

    public class TechnicalMachine: Attribute
    {
        public string TM { get; set; }
        public TechnicalMachine(string? tm)
        {
            TM = tm;
        }
    }


}
