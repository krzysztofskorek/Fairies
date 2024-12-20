using UnityEngine;

public class SpaceDetector : MonoBehaviour
{

    GameObject Player;
    float timePassed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag(nameof(Player));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timePassed += Time.deltaTime;

        if (timePassed > 2f) {
            print( Vector3.Magnitude(Player.transform.position -this.transform.position ));
            timePassed -= 2f;
        }
        
    }
}
