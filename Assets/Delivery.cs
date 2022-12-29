using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.5f;
    [SerializeField] private Color32 hasPackageColor = new Color32(0, 255, 27, 255);
    [SerializeField] private Color32 noPackageColor = new Color32(255, 255, 255, 255);

    private bool _hasPackage;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _hasPackage = false;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log($"{this.gameObject.name} collided with a {collision2D.gameObject.name}.");
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Package" && !_hasPackage)
        {
            Debug.Log($"Picked up: {collider2D.gameObject.name}");
            _hasPackage = true;
            _spriteRenderer.color = hasPackageColor;
            Destroy(collider2D.gameObject, destroyDelay);
        }

        if (collider2D.tag == "Customer" && _hasPackage)
        {
            _hasPackage = false;
            _spriteRenderer.color = noPackageColor;
            Debug.Log($"Package delivered to: {collider2D.gameObject.name}");
        }
    }
}