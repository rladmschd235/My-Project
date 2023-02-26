using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 500f;
    private Rigidbody2D rigid;

    void Start()
    {
        this.rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 direction = Vector2.up * jumpForce;
            this.rigid.AddForce(direction);
        }        
    }
}
