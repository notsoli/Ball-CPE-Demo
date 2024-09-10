using System;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float thrust = 20f;
    Rigidbody2D c_Rigidbody;
    SpriteRenderer c_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        c_Rigidbody = GetComponent<Rigidbody2D>();
        c_Rigidbody.freezeRotation = true;
        c_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        float speed = c_Rigidbody.velocity.magnitude;
        float gb = Math.Max(0, 1 - speed / 30);
        c_SpriteRenderer.color = new Color(1, gb, gb);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("1")) {
            c_Rigidbody.AddForce(-transform.right * thrust);
        }
        if (Input.GetKey("2")) {
            c_Rigidbody.AddForce(transform.up * thrust);
        }
        if (Input.GetKey("3")) {
            c_Rigidbody.AddForce(transform.right * thrust);
        }
    }
}
