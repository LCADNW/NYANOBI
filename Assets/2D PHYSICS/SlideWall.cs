using UnityEngine;

public class SlideWall : MonoBehaviour
{
    [SerializeField] PhysicsMaterial2D wallFriction;
    [SerializeField] PhysicsMaterial2D normalFriction;

    //When the player enters the 2D collider, it checks for the player tag. Then switches to a different PhysicsMaterial2D.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Collider2D playerCollider = collision.gameObject.GetComponent<Collider2D>();
            playerCollider.sharedMaterial = wallFriction;
        }

    }
    //When the player exits the 2D collider, it checks for the player tag. Then switches to a different PhysicsMaterial2D.
    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Collider2D playerCollider = collision.gameObject.GetComponent<Collider2D>();

            playerCollider.sharedMaterial = normalFriction;
        }

    }
}
