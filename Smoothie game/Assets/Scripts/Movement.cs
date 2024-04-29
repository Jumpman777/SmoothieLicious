using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed= 5;
    [SerializeField] Rigidbody2D rb2D;

    Vector2 movement;
    // Update is called once per frame

    private void Start()
    {
        rb2D= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       movement.x= Input.GetAxisRaw("Horizontal");
       movement.y= Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position* movement * moveSpeed* Time.fixedDeltaTime);
    }
}
