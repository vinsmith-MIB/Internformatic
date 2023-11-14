using UnityEngine;

public class BatasanGerak : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 lastPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastPosition = rb.position;
    }

    void FixedUpdate()
    {
        Vector2 currentPosition = rb.position;
        Vector2 moveDirection = currentPosition - lastPosition;
        float moveDistance = moveDirection.magnitude;

        if (moveDistance > 0)
        {
            RaycastHit2D hit = Physics2D.Raycast(lastPosition, moveDirection, moveDistance);
            if (hit.collider != null)
            {
                // Collider terdeteksi tepat di depan karakter
                rb.velocity = Vector2.zero; // Hentikan pergerakan karakter
            }
        }

        lastPosition = currentPosition;
    }
}
