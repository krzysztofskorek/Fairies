using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapChecker : MonoBehaviour
{
    [SerializeField] Grid map;
    [SerializeField] Tilemap tilemap;
    [SerializeField] Tile tile;

    const int size = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(checkifHasTile());


    }


    IEnumerator checkifHasTile()
    {
        int seconds = 1;
        while (true)

        {
            var lol = map.WorldToCell(transform.position);
            var xd = StartPalette(lol);
            print(lol);
            FillBox(xd.x, xd.y);
            yield return null;
        }
    }


    private Vector3Int StartPalette(Vector3Int pos)
    {
        int x = size * Mathf.FloorToInt((pos.x / size));
        int y = size * Mathf.FloorToInt((pos.y / size));
        int z = 0;
        return new Vector3Int(x, y, z);
    }


    private void FillBox(int startX, int startY)
    {
        for (int x = 0; x < size; x++)
        {

            for (int y = 0; y < size; y++)
            {
                tilemap.SetTile(new Vector3Int(startX + x - size, startY + y  , 0), tile);
            }
        }
    }
}
