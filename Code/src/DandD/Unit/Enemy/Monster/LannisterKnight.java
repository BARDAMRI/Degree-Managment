package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class LannisterKnight extends Monster{

    private Location location;
    private int experienceValue=50;
    private int attack=14;
    private int defence=8;
    private int healthPool=200;
    private int health;
    private char tile='k';
    private int visionRange=4;

    public LannisterKnight(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "k";}
    public String getName(){return "Lannister's Knight";}
}
