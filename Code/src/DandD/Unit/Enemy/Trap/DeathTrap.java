package DandD.Unit.Enemy.Trap;

import DandD.Location;

public class DeathTrap extends  Trap{

    private Location location;
    private int experienceValue;
    private int attack=100;
    private int defence=20;
    private int health=500;
    private char tile='D';
    public int visibilityTime=10;
    public  int visionRange=3;

    public DeathTrap(Location location1) { this.location=location1;}

    @Override
    public String toString() {
        return "D";
    }

    @Override
    public String getName() {
        return "Death Trap";
    }
}
