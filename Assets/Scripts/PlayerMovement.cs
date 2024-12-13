using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float runSpeed = 20f;

    float horizontal, vertical;
    Rigidbody2D body;


    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.linearVelocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
