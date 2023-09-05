using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeControl : MonoBehaviour
{
    private float speedx = 4f;
    private float speedy = 4f;
    private Rigidbody2D rigidbody2D;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Y = Input.GetAxis("Vertical") * speedy;
        float x = Input.GetAxis("Horizontal")* speedx;
        Vector2 direcion = new Vector2(Y, x);
        rigidbody2D.velocity = direcion * velocityScale;
        RaycastHit2D raycastHit2D = 
            Physics2D.Raycast(transform.position,direcion,3f, PlayeControl)
    }
}
