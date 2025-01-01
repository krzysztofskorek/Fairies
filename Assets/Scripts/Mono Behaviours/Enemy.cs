using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    SpriteRenderer sprite;

    private string playerTag = "Player";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(Vector3.MoveTowards(transform.position,player.transform.position, 1f * Time.fixedDeltaTime ) );
        if(transform.position.x < player.transform.position.x)
        {
            sprite.flipX = false;
        }
        else
        {
            sprite.flipX = true;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
             
            collision.gameObject.GetComponent<PlayerMovement>()?.GetDamaged();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {

            collision.gameObject.GetComponent<PlayerMovement>()?.StopDamage();
        }
    }
}
