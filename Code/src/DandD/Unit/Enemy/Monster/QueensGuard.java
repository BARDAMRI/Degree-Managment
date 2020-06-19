package DandD.Unit.Enemy.Monster;

import DandD.Location;

public class QueensGuard extends Monster{

    private Location location;
    private int experienceValue=400;
    private int attack=20;
    private int defence=15;
    private int healthPool=100;
    private int health;
    private char tile='q';
    private int visionRange=5;

    public QueensGuard(Location location1)
    {
        health=healthPool;
        this.location=location1;
    }
    public String toString(){return "q";}
    public String getName(){return "Queen's Guard";}
}
