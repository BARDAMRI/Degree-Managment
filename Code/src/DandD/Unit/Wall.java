package DandD.Unit;

import DandD.Location;

public class Wall implements Unit {

    private Location position;
    private char look;

    public Wall(char c, Location position) {

        this.look=c;
        this.position=position;
    }

    @Override
    public String toString() { return look+""; }
}
