using System;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log($"{this.gameObject.name} collided with a {col.gameObject.name}");
    }
}
