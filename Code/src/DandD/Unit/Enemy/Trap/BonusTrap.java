package DandD.Unit.Enemy.Trap;

import DandD.Location;

public class BonusTrap extends Trap{

    private Location location;
    private int experienceValue;
    private int attack=1;
    private int defence=1;
    private int health=1;
    private char tile='B';
    public int visibilityTime=5;
    public  int visionRange=4;


    public BonusTrap(Location location1) { this.location=location1;}
    @Override
    public String toString() {
        return "B";
    }

    @Override
    public String getName() {
        return "Bonus Trap";
    }
}
