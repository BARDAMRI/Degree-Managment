package DandD.Unit.Players.Worrior;

import DandD.Location;

public class TheHound extends Worrior {

    private Location location;
    private char tile;
    private int experience;
    private int level;
    private int healthPool=400;
    private int currentHealth;
    private int attack=20;
    private int defence=6;
    private int coolDown=5;

    public TheHound(Location location1)
    {
        currentHealth=healthPool;
        this.location=location1;
    }
    @Override
    public String getName() {
        return "The Hound";
    }
}
