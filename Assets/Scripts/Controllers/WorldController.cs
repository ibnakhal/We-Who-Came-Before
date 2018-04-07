using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {
    public MaterialHolder materialHolder;

    World world;
    public GameObject tileFab;

	// Use this for initialization
	void Start () {
        //create a world with tiles!
        world = new World();
        world.RandomizeTiles();

        for (int x = 0; x < world.Width; x++)
        {
            for (int y = 0; y < world.Height; y++)
            {
                Tile tile_data = world.GetTileAt(x, y);
                GameObject tile_go = Instantiate(tileFab) as GameObject;
                tile_go.name = ("Tile " + x + "," + y);
                tile_go.transform.position = new Vector3(tile_data.X, 0, tile_data.Y);



                if(tile_data.Type == Tile.TileType.Soil)
                {
                    Debug.Log(tile_data.Type);
                    tile_go.gameObject.GetComponent<Renderer>().material = materialHolder.materials[0];
                }
            }
        }
        world.RandomizeTiles();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTileTypeChange(Tile tile_data, GameObject tile_go)
    {
        switch (tile_data.Type)
        {
            case Tile.TileType.Soil:
                tile_go.gameObject.GetComponent<Renderer>().material = materialHolder.materials[0];
                break;
            case Tile.TileType.Concrete:
                Debug.LogError("Invalid, material not available");
                break;
            case Tile.TileType.Water:
                Debug.LogError("Invalid, material not available");
                break;
        }
    }
    }
