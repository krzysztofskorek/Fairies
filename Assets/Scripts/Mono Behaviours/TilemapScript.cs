using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapScript : MonoBehaviour
{
    [SerializeField]
    Tile tile;
    [SerializeField]
    Tilemap map;
    [SerializeField] GameObject detector;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        CreateInitMap();

    }


    private void CreateInitMap()
    {
        int size = TilemapUtils.size;
        FillBox(0,0);
        FillBox(-size,0);
        FillBox(0,-size);
        FillBox(-size,-size);

    }





    private void FillBox(int startX, int startY)
    {
        int size = TilemapUtils.size;
        for (int x = 0; x < size; x++)
        {

            for (int y = 0; y < size; y++)
            {
                map.SetTile(new Vector3Int(startX + x, startY + y, 0), tile);
            }
        }
         
    }

}

 
