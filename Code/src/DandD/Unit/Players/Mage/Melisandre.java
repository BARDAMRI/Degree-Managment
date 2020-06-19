package DandD.Unit.Players.Mage;

import DandD.Location;

public class Melisandre extends  Mage{

    private Location location;
    private char tile;
    private int experience;
    private int level;
    private int healthPool=100;
    private int currentHealth;
    private int attack=5;
    private int defence=1;
    private int manaPool=300;
    private int manaCost=30;
    private int spellPower=15;
    private int hitCount=5;
    private int Rang=6;

    public Melisandre(Location location1)
    {
        currentHealth=healthPool;
        this.location=location1;
    }
    @Override
    public String getName() {
        return "Melisandre";
    }
}
