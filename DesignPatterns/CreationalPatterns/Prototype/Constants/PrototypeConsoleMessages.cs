namespace DesignPatterns.CreationalPatterns.Prototype.Game.Constants
{
    internal class PrototypeConsoleMessages
    {
        internal const string MainQuestion = "What object do you want to create?\n" +
                                                "0: Quit\n" +
                                                "1: Create Soldier\n" +
                                                "2: Create Vehicle\n" +
                                                "3: Create Weapon\n";

        internal const string SoldierQuestion = "Which soldier do you want to create?\n" +
                                                "0: Quit\n" +
                                                "1: Blue Team Medic\n" +
                                                "2: Blue Team Sniper\n" +
                                                "3: Red Team Medic\n" +
                                                "4: Red Team Sniper\n";

        internal const string VehicleQuestion = "Which vehicle do you want to create?\n" +
                                                "0: Quit\n" +
                                                "1: Create Red Car\n" +
                                                "2: Create Red Truck\n" +
                                                "3: Create Blue Tank\n";

        internal const string WeaponQuestion = "Which weapon do you want to create?\n" +
                                               "0: Quit\n" +
                                               "1: Create Pistol\n" +
                                               "2: Create Machine Gun\n" +
                                               "3: Create Heavy Machine Gun\n" +
                                               "4: Create High Caliber Machine Gun\n" +
                                               "5: Create Sniper Rifle\n";

        internal const string SoldierNameQuestion = "What should we name that soldier?";

        internal const string VehicleIdQuestion = "What number should we give that vehicle?";

        internal const string NoSuchTypeError = "Unfortunately, there's no such type of object as you entered, please try again.";
    }
}