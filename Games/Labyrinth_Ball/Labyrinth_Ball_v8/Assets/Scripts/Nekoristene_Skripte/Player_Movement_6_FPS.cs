using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_6_FPS : MonoBehaviour
{
    public float speed = 100f;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector2 xMov = new Vector2(Input.GetAxisRaw("Horizontal") * transform.right.x, Input.GetAxisRaw("Horizontal") * transform.right.z);

        Vector2 zMov = new Vector2(Input.GetAxisRaw("Vertical") * transform.forward.x, Input.GetAxisRaw("Vertical") * transform.forward.z);


        Vector2 velocity = (xMov + zMov).normalized * speed * Time.deltaTime;

        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.y);
    }
}
