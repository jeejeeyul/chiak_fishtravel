using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoving : MonoBehaviour
{
    [Range(1f, 3f)]
    public float moveSpeed;
    public GameObject mover;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, mover.transform.position, moveSpeed * Time.deltaTime);
    }
}
