using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command 
                {
                    Id=0,
                    HowTo="Boil an egg",
                    Line="Boil water",
                    Plataform="Kettle & Pan"
                },
                new Command 
                {
                    Id=1,
                    HowTo="Cut bread",
                    Line="Get a knife",
                    Plataform="knife & chopping board"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {
                Id=0,
                HowTo="Boil an egg",
                Line="Boil water",
                Plataform="Kettle & Pan"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}