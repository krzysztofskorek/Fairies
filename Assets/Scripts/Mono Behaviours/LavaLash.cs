using UnityEngine;

public class LavaLash : MonoBehaviour
{

    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    
    void FixedUpdate()
    {
        transform.RotateAround(player.transform.position,Vector3.forward, 300f * Time.fixedDeltaTime);
    }
}
