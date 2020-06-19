package DandD.Unit.Enemy.Monster;

import DandD.Unit.Enemy.Enemy;

public abstract class Monster extends Enemy {


    private int visionRange;
    private String [] movement={"Up","Down","Left","Right"};

    public void attack(){throw new UnsupportedOperationException("not implemented yet");}
    public void defence(){throw new UnsupportedOperationException("not implemented yet");}
}
