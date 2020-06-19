package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class TheMountain extends Monster{

    private Location location;
    private int experienceValue=500;
    private int attack=60;
    private int defence=25;
    private int healthPool=1000;
    private int health;
    private char tile='M';
    private int visionRange=6;

    public TheMountain(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "M";}
    public String getName(){return "TheMountain";}
}
