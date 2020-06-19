package DandD.Unit.Enemy.Trap;

import DandD.Location;

public class queensTrap extends Trap{

    private Location location;
    private int experienceValue;
    private int attack=50;
    private int defence=10;
    private int health=200;
    private char tile='Q';
    public int visibilityTime=7;
    public  int visionRange=5;

    public  queensTrap(Location location1) { this.location=location1;}
    @Override
    public String toString() {
        return "Q";
    }

    @Override
    public String getName() {
        return "Queens Trap";
    }
}
