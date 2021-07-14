using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJetpackSystem : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    [SerializeField] float newton=1f;
    new Transform transform;
   /* [SerializeField] float rotationSpeed=1f;*/

   


    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Floor")
        if (Input.GetMouseButton(0))
        {
                rigidbody2D.AddForce(transform.up * newton);
                
        }

        if (Input.GetKey(KeyCode.A)) 
        {

            
            transform.Rotate(0, 0, -1);

        }
        if (Input.GetKey(KeyCode.D))
        {


            transform.Rotate(0, 0, 1);

        }
        


    }
}
