using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    private Vector2 mouse_position;

    // References
    private Rigidbody2D body;
    public Camera cam;
    public Weapon weapon;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mouse_position = cam.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            weapon.Shoot();
        }
    }
    private void FixedUpdate()
    {
        body.MovePosition(movement * speed * Time.fixedDeltaTime + body.position);

        Vector2 aim_direction = mouse_position - body.position;
        float aim_angle = Mathf.Atan2(aim_direction.y, aim_direction.x) * Mathf.Rad2Deg - 90f;
        body.rotation = aim_angle;
    }
}
