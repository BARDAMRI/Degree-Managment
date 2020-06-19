package DandD.Unit.Players.Worrior;

import DandD.Location;

public class JonSnow extends Worrior{

    private Location location;
    private char tile;
    private int experience;
    private int level;
    private int healthPool=300;
    private int currentHealth;
    private int attack=30;
    private int defence=4;
    private int coolDown=3;

    public JonSnow(Location location1)
    {
        currentHealth=healthPool;
        this.location=location1;
    }
    @Override
    public String getName() {
        return "Jon Snow";
    }

}
