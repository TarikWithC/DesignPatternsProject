using DesignPatterns.CreationalPatterns.Prototype.Concretes;

namespace DesignPatterns.CreationalPatterns.Prototype.Abstractions
{
    internal interface ISoldierFactory
    {
        public Soldier CreateBlueTeamMedic(string name);

        public Soldier CreateRedTeamMedic(string name);

        public Soldier CreateBlueTeamSniper(string name);

        public Soldier CreateRedTeamSniper(string name);
    }
}