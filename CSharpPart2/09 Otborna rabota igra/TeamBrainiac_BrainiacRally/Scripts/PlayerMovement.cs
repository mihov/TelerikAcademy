using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
   
    public float speed = 11f;
    public float reverseSpeed = 5.0f;
    public float turnSpeed = 0.6f;
	public float currentSpeed = 0.0f;

    private float moveDirection = 0.0f;
    private float turnDirection = 0.0f;

    // Use this for initialization
    void Start()
    {
        rigidbody.angularDrag = 2.0f;
        rigidbody.drag = 2.0f;
        rigidbody.useGravity = false;

        // FreezeRotation to avoid flipping
        // FreezePosition to avoid moving up and down
        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
		if(Input.GetKeyDown(KeyCode.Escape) == true)
		{	
			Application.LoadLevel("MainMenu");	
		}

		currentSpeed = Mathf.Abs(transform.InverseTransformDirection(rigidbody.velocity).z);
		
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");

        if (verticalAxis > 0)
        {
            moveDirection = verticalAxis * speed;
            turnDirection = horizontalAxis * turnSpeed;
        }
        else if (verticalAxis < 0)
        {
            moveDirection = verticalAxis * reverseSpeed;
            turnDirection = - horizontalAxis * turnSpeed;
        }

        rigidbody.AddRelativeForce(0, 0, moveDirection);
        rigidbody.AddRelativeTorque(0, turnDirection, 0); 

    }
}
