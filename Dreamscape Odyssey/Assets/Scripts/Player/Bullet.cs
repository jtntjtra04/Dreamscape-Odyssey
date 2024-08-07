using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion_effect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject explosion = Instantiate(explosion_effect, transform.position, Quaternion.identity);
        Destroy(explosion, 5f);
        Destroy(gameObject);
    }
}
