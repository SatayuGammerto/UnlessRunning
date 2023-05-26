using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] float gravity;
    [SerializeField] Vector2 velocity;
    [SerializeField] float jumpVelocity;
    [SerializeField] public float groundHeight = 10f;
    [SerializeField] public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded = false;
                velocity.y = jumpVelocity;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        if (!isGrounded)
        {
            pos.y += velocity.y * Time.fixedDeltaTime;
            velocity.y += gravity * Time.fixedDeltaTime;

            if (pos.y <= groundHeight)
            {
                pos.y = groundHeight;
                isGrounded = true;
            }
        }

        transform.position = pos; 
    }
}
