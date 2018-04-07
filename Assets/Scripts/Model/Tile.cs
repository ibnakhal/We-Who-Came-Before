using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile

{
    public enum TileType
    {
        Soil,
        Concrete,
        Water,
    }

    TileType type = TileType.Soil;

    public TileType Type
    {
        get
        {
            return type;
        }

        set
        {
            type = value;
            //call the callback; things have changed!


        }
    }

    public int X
    {
        get
        {
            return x;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }
    }

    LooseObject looseObject;
    InstalledObject installedObject;

    World world;
    int x;
    int y;





    //constructor grabs info about itself
    public Tile( World world, int x, int y )
    {
        this.world = world;
        this.x = x;
        this.y = y;

    }

}
