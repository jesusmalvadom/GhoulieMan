using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float maxSpeed = 6.0f;
    public float moveDirection;
    public bool facingRight = true;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
    }

	void FixedUpdate()
	{
        rb.velocity = new Vector2(moveDirection * maxSpeed, rb.velocity.y);
	}
}
