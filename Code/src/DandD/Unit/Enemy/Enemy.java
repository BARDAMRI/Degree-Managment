package DandD.Unit.Enemy;

import DandD.Location;
import DandD.Unit.Unit;

public abstract class Enemy implements Unit {
    
    private int experienceValue;
    private int attack;
    private int defence;
    private int health;
    private char tile;


    public String toString(){return ""+tile;}
    public String getName(){throw new UnsupportedOperationException("not implemented yet");}




}