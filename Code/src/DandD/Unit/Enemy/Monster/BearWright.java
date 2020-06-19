package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class BearWright extends Monster{

    private Location location;
    private int experienceValue=250;
    private int attack=75;
    private int defence=30;
    private int healthPool=1000;
    private int health;
    private char tile='b';
    private int visionRange=4;

    public BearWright(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "b";}
    public String getName(){return "Bear Wright";}
}
