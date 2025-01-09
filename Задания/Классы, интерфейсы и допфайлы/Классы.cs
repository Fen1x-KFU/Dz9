using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    internal class Bich : Game
    {
        public void Play()
        {
            Игры game = (Игры)0;
            Console.WriteLine($"Играть будем в {game}");
        }
    }

    internal class Mousetrap : Game
    {
        public void Play()
        {
            Игры game = (Игры)1;
            Console.WriteLine($"Играть будем в {game}");
        }
    }

    internal class Sea : Game
    {
        public void Play()
        {
            Игры game = (Игры)2;
            Console.WriteLine($"Играть будем в {game}");
        }
    }

    internal class Fishing : Game
    {
        public void Play()
        {
            Игры game = (Игры)3;
            Console.WriteLine($"Играть будем в {game}");
        }
    }

    internal class Postmen : Game
    {
        public void Play()
        {
            Игры game = (Игры)4;
            Console.WriteLine($"Играть будем в {game}");
        }
    }

    internal class Slide : Game
    {
        public void Play()
        {
            Игры game = (Игры)5;
            Console.WriteLine($"Играть будем в {game}");
        }
    }

    internal class RobberCossacks : Game        
    {
        public void Play()
        {
            Игры game = (Игры)6;
            Console.WriteLine($"Играть будем в {game}");
        }
    }

    internal class Team
    {
        protected int players; 
        protected string countries;

        public Team(int players, string countries, Game game)
        {
            this.players = players;
            this.countries = countries;
            Games = game;
        }
        public Game Games { private get; set; }
        public void Games()
        {
            Games.Play();
        }
    }
}
