using DesignPatterns.CreationalPatterns.Prototype.Game.Objects;

namespace DesignPatterns.CreationalPatterns.Prototype.Game.Abstractions
{
    internal interface ISoldierFactory
    {
        public Soldier CreateBlueTeamMedic(string name);

        public Soldier CreateRedTeamMedic(string name);

        public Soldier CreateBlueTeamSniper(string name);

        public Soldier CreateRedTeamSniper(string name);
    }
}