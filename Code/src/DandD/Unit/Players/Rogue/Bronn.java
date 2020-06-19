package DandD.Unit.Players.Rogue;

import DandD.Location;

public class Bronn extends Rogue{

    private Location location;
    private char tile;
    private int experience;
    private int level;
    private int healthPool=250;
    private int currentHealth;
    private int attack=35;
    private int defence=3;
    private int Cost=50;

    public Bronn(Location location1)
    {
        currentHealth=healthPool;
        this.location=location1;
    }
    @Override
    public String getName() {
        return "Bronn";
    }
}
