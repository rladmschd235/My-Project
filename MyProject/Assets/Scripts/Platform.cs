using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float speed = -0.03f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed, 0, 0);

        if(transform.position.x < -25.0f)
        {
            Destroy(gameObject);
        }
    }
}
