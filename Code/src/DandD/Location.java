package DandD;

public class Location {

    private int x;
    private int y;


    public Location(int x, int y)
    {
        this.x=x;
        this.y=y;
    }
    public int getX() {return this.x;}
    public int getY() {return this.y;}
    public void setX(int x){this.x=x;}
    public void setY(int y){this.y=y;}
    public void setLocation(int x, int y)
    {
        this.x=x;
        this.y=y;
    }
    public boolean Equals(Location loc)
    {
        return this.x==loc.x & this.y==loc.y;
    }
    public double distance(Location loc)
    {
        double a= Math.pow( this.y-loc.y,2);
        double b=Math.pow(this.x-loc.x,2);
        return Math.sqrt(a+b);
    }

}
