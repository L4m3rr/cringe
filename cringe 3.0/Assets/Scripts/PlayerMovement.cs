using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed; // Speed of the player
    [SerializeField] Rigidbody2D rb; // Rigidbody2D component for physics interactions
    private void Update()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (Mathf.Abs(horizontalInput) > 0f) 
        {
            rb.linearVelocity = new Vector2(horizontalInput * speed * Time.deltaTime, rb.linearVelocity.y); // Move the player horizontally
        }
        if (Mathf.Abs(verticalInput) > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, verticalInput * speed * Time.deltaTime); // Move the player vertically
        }
    }
}
