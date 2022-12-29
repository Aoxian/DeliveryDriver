using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 200f;
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float slowSpeed = 15f;
    [SerializeField] private float regularSpeed = 20f;
    [SerializeField] private float boostSpeed = 30f;

    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Bump")
        {
            moveSpeed = slowSpeed;
            Debug.Log($"Bumped into {collision2D.gameObject.name}, speed slowed!");
        }

    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Speed Boost!");
        }

        if (collider2D.tag == "Package" && moveSpeed != boostSpeed)
        {
            moveSpeed = regularSpeed;
            Debug.Log($"Speed back to regular speed");
        }
    }
}