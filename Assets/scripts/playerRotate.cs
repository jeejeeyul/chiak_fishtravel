using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotate : MonoBehaviour
{

    public GameObject mover;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");//상하좌우 입력 받아오기( 범위는 -1~1)
        if (x != 0 || y != 0)
        {
            Vector2 newPos = mover.transform.position - transform.position;
            float rotZ = Mathf.Atan2(newPos.y, newPos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }

    }
}
