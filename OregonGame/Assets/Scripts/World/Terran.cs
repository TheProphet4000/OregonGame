using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terran : MonoBehaviour
{
    public GameObject Tile;
    public List<GameObject> Tiles;
    // Start is called before the first frame update
    void Start()
    {
        Tiles = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        TileGenerate();
    }

    public void TileGenerate()
    {
        GameObject newtile = Instantiate(Tile, Vector2.zero, Quaternion.identity) as GameObject;
        Tiles.Add(newtile);
    }
}
