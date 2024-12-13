using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapScript : MonoBehaviour
{
    [SerializeField]
    Tile tile;
    [SerializeField]
    Tilemap map;

    private int mapSize = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        CreateInitMap();

    }


    private void CreateInitMap()
    {

        FillBox(0,0);
        FillBox(-mapSize,0);
        FillBox(0,-mapSize);
        FillBox(-mapSize,-mapSize);

    }





    private void FillBox(int startX, int startY)
    {
        for (int x = 0; x < mapSize; x++)
        {

            for (int y = 0; y < mapSize; y++)
            {
                map.SetTile(new Vector3Int(startX + x, startY + y, 0), tile);
            }
        }
    }

}

 
