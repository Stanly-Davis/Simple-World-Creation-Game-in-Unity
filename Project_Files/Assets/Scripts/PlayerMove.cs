
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private  Rigidbody rb;
    public float speed = 10f;
    public float jumpspeed = 30f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //To prevent capsule from falling or rotating, we freeze rotation component
        rb.freezeRotation = true;
        
    }

    
    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));


        if(Input.GetButton("Jump"))
         {
            rb.AddForce(transform.up*jumpspeed);
            rb.MovePosition(transform.position + (input * Time.deltaTime * speed));
         } 

         rb.MovePosition(transform.position + (input * Time.deltaTime * speed));
        
    }
}
