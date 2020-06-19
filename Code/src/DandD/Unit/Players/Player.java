package DandD.Unit.Players;

import DandD.Unit.Unit;

public class Player implements Unit {

    private int xPosition;
    private int yPosition;
    private char tile;
    private int experience;
    private int level;
    private int healthPool;
    private int currentHealth;
    private int attack;
    private int defence;

    public Player(){}
    @Override
    public String toString(){return "@";}
    public String getName(){throw new UnsupportedOperationException("not implemented yet");}
    public String describe(){throw new UnsupportedOperationException("not implemented yet");}
    public void attack(){throw new UnsupportedOperationException("not implemented yet");}
    public void defence(){throw new UnsupportedOperationException("not implemented yet");}
}
