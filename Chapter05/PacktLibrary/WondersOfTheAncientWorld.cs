namespace Packt.Shared
{
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        None = 0b_0000_0000, // т.е. 0
        GreatPyramidOfGiza = 0b_0000_0001, // т.е. 1
        HangingGardensOfBabylon = 0b_0000_0010, // т.е. 2
        StatueOfZeusAtOlympia = 0b_0000_0100, // т.е. 4
        TempleOfArtemisAtEphesus = 0b_0000_1000, // т.е. 8
        MausoleumAtHalicarnassus = 0b_0001_0000, // т.е. 16
        ColossusOfRhodes = 0b_0010_0000, // т.е. 32
        LighthouseOfAlexandria = 0b_0100_0000 // т.е. 64

    }
}