using UnityEngine;
using System.Collections;
[ExecuteInEditMode()]

public class SpeedGUI : MonoBehaviour
{
    public GUISkin racingGUISkin;

    public int offsetX = 0;
    public int offsetY = 0;

    public int lapOffsetX = 0;
    public int lapOffsetY = 0;

    private float speed = 0.0f;
    private int lap = 0;

    private GameObject playerGameObject;

    // Use this for initialization
    void Start()
    {
        playerGameObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        PlayerMovement playerMovement = playerGameObject.GetComponent<PlayerMovement>();

        speed = playerMovement.currentSpeed * 10;
        lap = CheckpointController.currentLap;


        int rpm = ((this.RealisticSpeed((int)speed)) % 40) * 250;
        int gear = this.RealisticSpeed((int)speed) / 40 + 1;
        if (speed < 5 ) gear = 0;
        
        GUI.skin = racingGUISkin;
        GUI.Label(new Rect(Screen.width + lapOffsetX,Screen.height +lapOffsetY - 30, 1000, 100), "Lap "+ lap.ToString("f0"));
        GUI.Label(new Rect(Screen.width + offsetX, Screen.height + offsetY, 1000, 100), "Speed "+ this.RealisticSpeed((int) speed).ToString("f0"));

        //hacking letter spacing because of font issue
        GUI.Label(new Rect(Screen.width + offsetX, Screen.height - 100, 100, 100), "R");
        GUI.Label(new Rect(Screen.width + offsetX + 15, Screen.height + offsetY - 28, 100, 100), "P");
        GUI.Label(new Rect(Screen.width + offsetX + 35, Screen.height + offsetY - 28, 100, 100), "M ");
        GUI.Label(new Rect(Screen.width + offsetX + 62, Screen.height + offsetY - 28, 100, 100), rpm.ToString("f0"));

        GUI.Label(new Rect(Screen.width + offsetX - 60, Screen.height + offsetY, 1000, 100), "G"+ gear.ToString("f0"));

        //GUI.Label(new Rect(Screen.width / 2 + offsetX, Screen.height / 2 + offsetY, 1000, 100), "Speed "+ speed.ToString("f0"));
        //GUI.Label(new Rect(Screen.width / 2 + lapOffsetX, Screen.height / 2 + lapOffsetY, 1000, 100), "Lap "+ lap.ToString("f0"));
        //
    }

   /*
    * Gives the speed a boost and puts it little more closer to the real values.
    */
    private int RealisticSpeed(int speed)
    {
        double multiplier = 0.0;

        if (speed <= 35)
        {
            multiplier = 1.2;
        }
        else if (speed > 35 && speed <= 43)
        {
            multiplier = Mathf.Sqrt(speed) - 0.2;

            if (multiplier > 2.5)
            {
                multiplier = 2.5;
            }
        }
        else if (speed > 43)
        {
            multiplier = 2.9;
        }

        return (int) (speed * multiplier);
    }
}
