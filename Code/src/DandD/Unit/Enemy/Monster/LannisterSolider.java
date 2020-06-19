package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class LannisterSolider extends Monster{

    private Location location;
    private int experienceValue=25;
    private int attack=8;
    private int defence=3;
    private int healthPool=80;
    private int health;
    private char tile='s';
    private int visionRange=3;

    public LannisterSolider(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "s";}
    public String getName(){return "Lannister's Solider";}
}
