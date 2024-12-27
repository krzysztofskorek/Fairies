using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;


public class GroundDetector : MonoBehaviour
{
    private int size = 20;
    [SerializeField] Grid grid;
    [SerializeField] Tilemap ground;
    [SerializeField] Tile tile;
    [SerializeField] GameObject Raf;
    private void Start()
    {
        StartCoroutine(nameof(DetectStuff));


    }


    IEnumerator DetectStuff()
    {

        while (true)
        {

            var xd = grid.WorldToCell(this.transform.position);
            Vector3Int ex = Slapper(xd);
            FillBox(ex.x, ex.y);
            yield return new WaitForSeconds(0.2f);
        }
    }


    private Vector3Int Slapper(Vector3Int pos)
    {
        float x = size * Mathf.Floor((float)pos.x / size);
        float y = size * Mathf.Floor((float)pos.y / size);
        float z = 0;
        Vector3Int newPos = new Vector3Int((int)x, (int)y, (int)z);
        

        return newPos;
    }


    private void FillBox(int startX, int startY)
    {
        if (ground.HasTile(new Vector3Int(startX, startY, 0))) {
            return;
        }
          
        
        for (int x = 0; x < size; x++)
        {

            for (int y = 0; y < size; y++)
            {
                ground.SetTile(new Vector3Int(startX + x, startY + y, 0), tile);
            }
        }
        Vector3 farPos;
        farPos = grid.CellToWorld(new Vector3Int(startX + size /2, startY + size /2, 0));
        
        
        Instantiate(Raf, farPos, Quaternion.identity);
    }
}
