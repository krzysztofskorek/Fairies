using UnityEngine;
using UnityEngine.Tilemaps;
public class SpaceDetector : MonoBehaviour
{

    GameObject Player;
    float timePassed;
    Grid grid;
    Tilemap ground;
    private int maxDist = 200;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag(nameof(Player));
        grid = GameObject.Find("Grid").GetComponent<Grid>();
        ground = grid.GetComponentInChildren<Tilemap>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timePassed += Time.deltaTime;

        if (timePassed > 2f)
        {   if((Player.transform.position -  transform.position).magnitude > maxDist)  
                RemoveTiles();
            timePassed -= 2f;
        }

    }

    private void RemoveTiles()
    {
        Vector3 palettePos = new Vector3((transform.position.x - 20 / 2) + 0.2f, (transform.position.y - 20 / 2) + 0.2f, 0);
        Vector3Int tilePos = grid.WorldToCell(palettePos);
        for (int x = 0; x < 20; x++)
        {

            for (int y = 0; y < 20; y++)
            {
                ground.SetTile(new Vector3Int(tilePos.x + x, tilePos.y + y, 0), null);
            }
        }
        Destroy(gameObject);

    }
}
