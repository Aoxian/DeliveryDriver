using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log($"{this.gameObject.name} collided with a {collision2D.gameObject.name}.");
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Package") Debug.Log($"Picked up package: {collider2D.gameObject.name}");
        if (collider2D.tag == "Customer") Debug.Log($"Visited the customer: {collider2D.gameObject.name}");
    }
}