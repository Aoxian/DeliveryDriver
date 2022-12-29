using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage = false;
    [SerializeField] private float destroyDelay = 0.5f;
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log($"{this.gameObject.name} collided with a {collision2D.gameObject.name}.");
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Package" && !hasPackage)
        {
            Debug.Log($"Picked up: {collider2D.gameObject.name}");
            hasPackage = true;
            Destroy(collider2D.gameObject, destroyDelay);
        }

        if (collider2D.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            Debug.Log($"Package delivered to: {collider2D.gameObject.name}");
        }
    }
}