package DandD.Unit;

import DandD.Location;

public class EmptyTile implements  Unit{

    private Location position;
    private char look;

    public EmptyTile(char c, Location position) {

        this.look=c;
        this.position=position;
    }

    @Override
    public String toString() {
        return look+"";
    }
}