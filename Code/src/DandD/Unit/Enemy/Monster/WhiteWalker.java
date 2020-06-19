package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class WhiteWalker extends Monster{

    private Location location;
    private int experienceValue=1000;
    private int attack=150;
    private int defence=50;
    private int healthPool=2000;
    private int health;
    private char tile='w';
    private int visionRange=6;

    public WhiteWalker(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "W";}
    public String getName(){return "WhiteWalker";}
}
