using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapScript : MonoBehaviour
{
    [SerializeField]
    Tile tile;
    [SerializeField]
    Tilemap map;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 pos = new Vector3(0,1.8f,0);
        print(map.WorldToCell(pos));

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
