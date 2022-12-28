using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log($"{this.gameObject.name} collided with a {collision2D.gameObject.name}.");
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        Debug.Log($"{this.gameObject.name} passed trough {collider2D.gameObject.name} trigger.");
    }
}