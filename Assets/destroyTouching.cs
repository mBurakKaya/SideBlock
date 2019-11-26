using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTouching : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
