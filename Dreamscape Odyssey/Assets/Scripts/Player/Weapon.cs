using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet_prefab;
    public Transform firepoint;
    public float shoot_force = 20f;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bullet_prefab, firepoint.position, firepoint.rotation);
        Rigidbody2D bullet_rb = bullet.GetComponent<Rigidbody2D>();
        bullet_rb.AddForce(firepoint.up *  shoot_force, ForceMode2D.Impulse);
    }
}
