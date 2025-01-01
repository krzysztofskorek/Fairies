using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(nameof(Spawner));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy()
    {
        Vector3 enemySpawnPos = GetPointOnCircle();
        enemySpawnPos += this.transform.position;

        GameObject enemy = EnemyPooler.SharedInstance.GetPooledObject();
        if (enemy != null)
        {
            enemy.transform.position = enemySpawnPos;
            enemy.transform.rotation = Quaternion.identity;
            enemy.SetActive(true);
        }

    }



    private IEnumerator Spawner()
    {

        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            SpawnEnemy();

        }

    }

    private Vector3 GetPointOnCircle()
    {
        int size = 16;
        int dir;
        int side = Random.Range(0, 2);
        
        if (side == 0) // hor
        {
            int hor = Random.Range(0, 2);

            if (hor == 1)
                dir = 1;
            else
                dir = -1;

            return new Vector3(size * dir, Random.Range(0, size), 1);

        }
        else // vert
        {
            int vert = Random.Range(0, 2);
            if (vert == 1)
                dir = 1;
            else
                dir = -1;
            return new Vector3(Random.Range(0, size), size * dir, 1);



        }

    }
}
