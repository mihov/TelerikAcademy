using UnityEngine;
using System.Collections;

public class EnemyAnimation_2 : MonoBehaviour 
{
	public int columns					= 6;
	public int rows						= 6;
	
	//ANIMATION CONTROL VARIABLES
	public int currentFrame				= 1;
	public int currentAnim				= 0;
	public float animTime				= 0.0f;
	public float fps					= 10.0f;
	
	public bool explode					= false;
	
	private Vector2 framePosition;
	private Vector2 frameSize;
	private Vector2 frameOffset;
	private int i;
	
	private float carVelocity;
	private Vector3 currentWaypoint;
	
	private bool turning				= false;

	//ANIMATION FRAMES VARIABLES
	private int idle					= 7;	
	private int drive					= 7;
	private int driveLeft				= 8;
	private int driveRight				= 9;
		
	//ANIMATION ID VARIABLES
	private int animIdle				= 7;	
	private int animDrive				= 7;
	private int animDriveLeft			= 8;
	private int animDriveRight			= 9;

	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		HandleAnimation();		
	}
	
	void HandleAnimation()
	{
		FindAnimation();
		PlayAnimation();	
	}
	
	float FindAngle(Vector3 fromVector, Vector3 toVector, Vector3 upVector)
	{
		if(toVector == Vector3.zero)
		{
			return 0.0f;	
		}
		
		float angle = Vector3.Angle(fromVector, toVector);
		Vector3 normal = Vector3.Cross(fromVector, toVector); // is rotating left or right?
		angle *= Mathf.Sign(Vector3.Dot(normal, upVector));
		angle *= Mathf.Deg2Rad; // convert from degree to radians
		return angle;
	}
	
	void FindAnimation()
	{
		float angle;
		
		EnemyMovement enemyMovement = transform.parent.GetComponent<EnemyMovement>();
		carVelocity = enemyMovement.currentSpeed;
		currentWaypoint = enemyMovement.currentWaypointPosition;
		angle = FindAngle(transform.forward, currentWaypoint - transform.parent.position, transform.up);
		
		
		if(carVelocity > 0.1f)
		{
			currentAnim	= animDrive;
			if(turning) // change animation of weels when turning
			{
				if(angle < 0.0f)
				{
					currentAnim = animDriveLeft;	
				}
			
				if(angle > 0.0f)
				{
					currentAnim = animDriveRight;	
				}
			}
			
		}
		if(carVelocity < 0.1f)
		{
			currentAnim = animIdle;	
		}
	}
	
	void PlayAnimation()
	{
		animTime -= Time.deltaTime;
		if(animTime <= 0)
		{
			currentFrame += 1;
			animTime += 1.0f / fps;
		}
		
		//LOOPING ANIMATIONS
		if(currentAnim == animIdle)
		{
			currentFrame = idle;	
		}		
		if(currentAnim == animDrive)
		{
			currentFrame = drive;
		}
		if(currentAnim == animDriveLeft)
		{
			currentFrame = driveLeft; 
		}
		if(currentAnim == animDriveRight)
		{
			currentFrame = driveRight;
		}		
		
		framePosition.y = 1;
		for(i = currentFrame; i > columns; i -= rows)
		{
			framePosition.y += 1;	
		}
		framePosition.x = i - 1; 
		
		frameSize = new Vector2(1.0f / columns, 1.0f / rows);
		frameOffset = new Vector2(framePosition.x / columns, 1.0f - (framePosition.y / rows));
		
		renderer.material.SetTextureScale("_MainTex", frameSize);
		renderer.material.SetTextureOffset("_MainTex", frameOffset);	
	}
	
	void OnTriggerStay(Collider other)
	{
		if(other.tag == "CheckPoint")
		{
			turning = true;	
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "CheckPoint")
		{
			turning = false;	
		}
	}
}
