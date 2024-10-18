using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerReverse : MonoBehaviour
{
    public GameObject mover;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (mover.transform.position.x - transform.position.x < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, -0.333f, transform.localScale.z);
        }
        else if (mover.transform.position.x - transform.position.x > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, 0.333f, transform.localScale.z);
        }
    }
}
