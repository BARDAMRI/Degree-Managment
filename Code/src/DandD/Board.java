package DandD;

import DandD.Unit.Enemy.Enemy;
import DandD.Unit.Players.Player;
import DandD.Unit.Unit;
import java.util.*;


public class Board {

    private Unit[][] board;
    private boolean turn;
    private Player player;
    private List<Enemy> unitsPosition = new LinkedList<>();

    public  Board(List<String> level) {
        List<String> lines = level;
        board = new Unit[lines.size()][longestRowLength(lines)];
        int rowPlace = 0;
        for (String row : lines) {
            for (int i = 0; i < row.length(); i++) {
                char c = row.charAt(i);
                if (c == '.' | c == '#') {
                    board[rowPlace][i] = UnitsMaker.createTile(c, new Location(rowPlace, i));
                } else {
                    if (c == '@') {
                        board[rowPlace][i] = new Player();
                        }
                     else {

                        board[rowPlace][i] = UnitsMaker.createEnemy(row.charAt(i), new Location(rowPlace, i));
                    }
                }
            }
        }
    }
    public int longestRowLength(List<String> lines)
    {
        int a=0;
        for(String row:lines)
        {
            if(row.length()>a)
                a=row.length();
        }
        return a;
    }
//    public void playAllTurns() {
//        Scanner reader = new Scanner(System.in);
//
//        char c = reader.next().charAt(0);
//
//        PlayerTurn(c);
//        enemyTurn();
//
//    }
//    public void enemyTurn() {
//        for (Enemy enemy : unitsPosition) {
//            Position moveTo;
//            if (Position.range(enemy.getPosition(), player.getPosition()) < enemy.getRange())
//                moveTo = enemy.inRangeMove(player);//monster move to player ,trap attack player and not moves
//            else
//                moveTo = enemy.outOfRangeMove();
//            if (enemy.Move(Board[moveTo.getX()][moveTo.getY()])) {
//                moveUnit(enemy.getPosition(), moveTo);
//            }
//        }
//    }
//
//    public void PlayerTurn(char move) {
//        int playerX = player.getPosition().getX();
//        int playerY = player.getPosition().getY();
//        Position moveTo = player.getPosition();
//        boolean canMove = false;
//        switch (move) {
//            //monster
//            case 'w':
//                canMove = Board[playerX][playerY].Move(Board[playerX-1][playerY ]);
//                moveTo = new Location(playerX-1, playerY );
//                break;
//            case 's':
//                canMove = Board[playerX][playerY].Move(Board[playerX+1][playerY ]);
//                moveTo = new Position(playerX+1, playerY );
//                break;
//            case 'a':
//                canMove = Board[playerX][playerY].Move(Board[playerX ][playerY-1]);
//                moveTo = new Position(playerX , playerY-1);
//                break;
//            case 'd':
//                canMove = Board[playerX][playerY].Move(Board[playerX ][playerY+1]);
//                moveTo = new Position(playerX , playerY+1);
//                break;
//            case 'q':
//                canMove = Board[playerX][playerY].Move(Board[playerX][playerY]);
//                moveTo = new Position(playerX, playerY);
//                break;
//              case 'e':
//                  player.castAbility(unitsPosition);
//
//
//        }
//        if (canMove) {
//
//            moveUnit(player.getPosition(), moveTo);
//        }
//    }
}
