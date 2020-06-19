package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class NightsKing extends Monster{

    private Location location;
    private int experienceValue=5000;
    private int attack=300;
    private int defence=150;
    private int healthPool=5000;
    private int health;
    private char tile='K';
    private int visionRange=8;

    public NightsKing(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "K";}
    public String getName(){return "Night's King";}
}
