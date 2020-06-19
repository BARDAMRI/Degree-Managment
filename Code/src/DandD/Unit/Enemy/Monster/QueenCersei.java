package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class QueenCersei extends Monster{

    private Location location;
    private int experienceValue=1000;
    private int attack=10;
    private int defence=10;
    private int healthPool=100;
    private int health;
    private char tile='C';
    private int visionRange=1;

    public QueenCersei(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "C";}
    public String getName(){return "Queen Cersei";}
}
