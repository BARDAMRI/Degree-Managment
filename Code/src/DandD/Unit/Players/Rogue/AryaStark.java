package DandD.Unit.Players.Rogue;

import DandD.Location;

public class AryaStark extends Rogue {

    private Location location;
    private char tile;
    private int experience;
    private int level;
    private int healthPool=150;
    private int currentHealth;
    private int attack=40;
    private int defence=2;
    private int Cost=20;

    public AryaStark(Location location1)
    {
        currentHealth=healthPool;
        this.location=location1;
    }

    @Override
    public String getName() {
        return "Arya Stark";
    }
}
