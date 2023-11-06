namespace EmGame
{
    public enum TeamType
    {
        HUMAN,
        DWARF,
        ORC,
        ELF,
        GNOME,
        DEMON,

    }
    public class Warrior
    {
        private int _x, _y;
        private int _life;
        private double _accuracity;
        private int _armor;
        private double _lucky;
        private TeamType _team;
    }
}
