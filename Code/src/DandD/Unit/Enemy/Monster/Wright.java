package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class Wright extends  Monster{

    private Location location;
    private int experienceValue=100;
    private int attack=30;
    private int defence=15;
    private int healthPool=600;
    private int health;
    private char tile='z';
    private int visionRange=3;

    public Wright(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "z";}
    public String getName(){return "Wright";}
}
