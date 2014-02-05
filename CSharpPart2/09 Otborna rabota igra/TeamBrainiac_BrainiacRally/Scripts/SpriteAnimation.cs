using UnityEngine;
using System.Collections;

public class SpriteAnimation : MonoBehaviour
{


		public int columbs = 6;
		public int rows = 6;

		//ANIMATION CONTROL VARIABLES
		public int currentFrame = 1;
		public int currentAnim = 0;
		public float animTime = 0.0f;
		public float fps = 15.0f;
		public bool explode = false;
		private Vector2 framePosition; //
		private Vector2 frameSize;     //
		private Vector2 frameOffset;
		private int i;
		private float carVelocity;
	
		//ANIMATION FRAMES (START AND END) VARIABLES
		private int idle = 1;
		private int drive = 1;
		private int turnLeft = 2;
		private int turnRight = 3;

	
		//ANIMATION ID VARIABLES
		private int animIdle = 0;
		private int animDrive = 1;
		private int animDriveLeft = 2;
		private int animDriveRight = 3;


		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				HandleAnimation ();
		}

		void HandleAnimation ()
		{
				FindAnimation ();
				PlayAnimation ();
		}

		void FindAnimation ()
		{
			
				if (Input.GetAxis("Vertical") > 0.0f) //if "up" key is press
				{
					if(Input.GetAxis("Horizontal") < 0.0f)
					{
						currentAnim = animDriveLeft;
					}
					else if(Input.GetAxis("Horizontal") > 0.0f)
					{
						currentAnim = animDriveRight;
					}
					else
					{
						currentAnim = animDrive;
					}
				}
				else if (Input.GetAxis("Horizontal") < 0.0f) 
				{
					currentAnim = animDriveLeft;
				} 
				else if (Input.GetAxis("Horizontal") > 0.0f) 
				{
					currentAnim = animDriveRight;
				}
				else 
				{
					currentAnim = animIdle;
				}
		}

		void PlayAnimation () //PlayAnimation METHOD
		{

				animTime -= Time.deltaTime;

				if (animTime <= 0) 
				{
					currentFrame += 1;
					animTime += 1.0f;
				}

				//LOOPING ANIMATIONS
				if (currentAnim == animIdle) 
				{
					currentFrame = idle;
				}
				if (currentAnim == animDrive) 
				{
					currentFrame = drive;
				}
				if (currentAnim == animDriveLeft) 
				{
					currentFrame = turnLeft;
				}
				if (currentAnim == animDriveRight) 
				{
					currentFrame = turnRight;
				}


				framePosition.y = 1;

				for (i = currentFrame; i > columbs; i-= rows) 
				{
					framePosition.y += 1;
				}
				framePosition.x = i - 1;

				frameSize = new Vector2 (1.0f / columbs, 1.0f / rows);
				frameOffset = new Vector2 (framePosition.x / columbs, 1.0f - (framePosition.y) / rows);

				renderer.material.SetTextureScale ("_MainTex", frameSize);
				renderer.material.SetTextureOffset ("_MainTex", frameOffset);
		}
}
