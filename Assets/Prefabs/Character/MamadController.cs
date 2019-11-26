using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamadController : MonoBehaviour {
    Rigidbody2D rb;
    bool rotate=false;
    float jumpForce=6;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(rb.velocity.y > 5){
            rb.AddForce(-rb.velocity);
        }
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x<0&&!rotate)
        {
            transform.Rotate(new Vector3(0, 180, 0));
            rotate = true;
        }
        else if (x>0&&rotate)
        {
            transform.Rotate(new Vector3(0, 180, 0));
            rotate = false;
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 move = transform.right * Time.deltaTime * 8f;
            this.transform.Translate(move, Space.World);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jumpForce);
        }
    }
 

}
