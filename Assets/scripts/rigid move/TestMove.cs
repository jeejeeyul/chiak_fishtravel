using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour

{   public float maxSpeed;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    
    void Update() {
        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0)
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        else if (h < 0)
        {
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        if(rigid.velocity.x > maxSpeed) // right max speed
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }
        else if (rigid.velocity.x < maxSpeed*(-1))// left max speed
        {
            rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
        }

        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(Vector2.up * v, ForceMode2D.Impulse);
        if(rigid.velocity.y > maxSpeed) // right max speed
        {
            rigid.velocity = new Vector2(rigid.velocity.x, maxSpeed);
        }
        else if (rigid.velocity.y < maxSpeed*(-1))// left max speed
        {
            rigid.velocity = new Vector2(rigid.velocity.x, maxSpeed*(-1));
        }
    }
}
