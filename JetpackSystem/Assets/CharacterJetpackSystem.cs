using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJetpackSystem : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    [SerializeField] float newton=1f;
    new Transform transform;
    [SerializeField] float rotationSpeed=1f;
    [SerializeField] float horizontalSpeed = 1f;

    
   


    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.E))
        {


            transform.Rotate(0, 0, -rotationSpeed);

        }
        if (Input.GetKey(KeyCode.Q))
        {


            transform.Rotate(0, 0, rotationSpeed);

        }
        if(horizontal<0)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
            transform.position += new Vector3(horizontal * horizontalSpeed, 0, 0);
        }
        if (horizontal>0)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);
            transform.position += new Vector3(horizontal * horizontalSpeed, 0, 0);
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Floor" || collision.tag == "MainCamera")
        if (Input.GetMouseButton(0))
        {

                rigidbody2D.AddForce(transform.up * newton);


                

            }

        
        

    }
}
