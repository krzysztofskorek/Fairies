using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float runSpeed = 20f;

    Vector2 movement;
    Rigidbody2D body;
    Animator animator;
    InputSystem_Actions inputActions;

    private string horizontal = "Horizontal";
    private string vertical = "Vertical";
    private string last_horizontal = "LastHorizontal";
    private string last_vertical = "LastVertical";
    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }



    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }
    void Update()
    {
        movement = inputActions.Player.Move.ReadValue<Vector2>();
        animator.SetFloat(horizontal, movement.x);
        animator.SetFloat(vertical, movement.y);


        if (movement != Vector2.zero)
        {
            animator.SetFloat(last_horizontal, movement.x);
            animator.SetFloat(last_vertical, movement.y);
        }
         
    }

    private void FixedUpdate()
    {
        body.linearVelocity = movement * runSpeed;
    }
}
