package DandD.Unit.Players.Mage;

import DandD.Location;

public class ThorosOfMyr extends  Mage{

    private Location location;
    private char tile;
    private int experience;
    private int level;
    private int healthPool=250;
    private int currentHealth;
    private int attack=25;
    private int defence=4;
    private int manaPool=150;
    private int manaCost=20;
    private int spellPower=20;
    private int hitCount=3;
    private int Rang=4;

    public ThorosOfMyr(Location location1)
    {
        currentHealth=healthPool;
        this.location=location1;
    }
    @Override
    public String getName() {
        return "Thoros Of Myr";
    }

}
