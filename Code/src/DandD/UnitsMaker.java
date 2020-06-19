package DandD;

import DandD.Unit.EmptyTile;
import DandD.Unit.Enemy.Enemy;
import DandD.Unit.Enemy.Monster.*;
import DandD.Unit.Enemy.Trap.BonusTrap;
import DandD.Unit.Enemy.Trap.DeathTrap;
import DandD.Unit.Enemy.Trap.Trap;
import DandD.Unit.Enemy.Trap.queensTrap;
import DandD.Unit.Players.Mage.Melisandre;
import DandD.Unit.Players.Mage.ThorosOfMyr;
import DandD.Unit.Players.Player;
import DandD.Unit.Players.Rogue.AryaStark;
import DandD.Unit.Players.Rogue.Bronn;
import DandD.Unit.Players.Worrior.JonSnow;
import DandD.Unit.Players.Worrior.TheHound;
import DandD.Unit.Unit;
import DandD.Unit.Wall;

public class UnitsMaker {

    public static Unit createTile(char symbol, Location position) {
        switch (symbol) {
            //monster
            case'.':
                return new EmptyTile('.',position);
            case'#':
                return new Wall('#',position);
        }
        return null;
    }

    public static Enemy createEnemy(char symbol, Location position) {
        switch (symbol) {
            case 's':
                return new LannisterSolider(position);
            case 'k':
                return new LannisterKnight(position);
            case 'q':
                return new QueensGuard(position);
            case 'z':
                return new Wright(position);
            case 'b':
                return new BearWright(position);
            case 'g':
                return new GiantWright(position);
            case 'w':
                return new WhiteWalker(position);
            case 'M':
                return new TheMountain(position);
            case 'C':
                return new QueenCersei(position);
            case 'K':
                return new NightsKing(position);
            //traps
            case 'B':
                return new BonusTrap(position);
            case 'Q':
                return new queensTrap(position);
            case 'D':
                return new DeathTrap(position);
        }
        return null;
    }
    public static Player createPlayer(char symbol, Location position) {
        switch (symbol) {
            case '1':
                return new JonSnow(position);
            case '2':
                return new TheHound(position);
            case '3':
                return new Melisandre(position);
            case '4':
                return new ThorosOfMyr(position);
            case '5':
                return new AryaStark(position);
            case '6':
                return new Bronn(position);

        }
        return null;
    }

}
