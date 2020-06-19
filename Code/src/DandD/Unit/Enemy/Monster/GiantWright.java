package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class GiantWright extends Monster {

    private Location location;
    private int experienceValue=500;
    private int attack=100;
    private int defence=40;
    private int healthPool=1500;
    private int health;
    private char tile='g';
    private int visionRange=5;

    public GiantWright(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "g";}
    public String getName(){return "Giant Wright";}
}
