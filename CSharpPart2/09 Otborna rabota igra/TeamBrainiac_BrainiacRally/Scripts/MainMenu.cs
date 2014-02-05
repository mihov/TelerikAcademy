using UnityEngine;
using System.Collections;
[ExecuteInEditMode]

public class MainMenu : MonoBehaviour
{
    public GUISkin racingGUISkin;
    public Vector2 buttonStartLocation;
    public Vector2 buttonExitLocation;
    public _GUIClasses.Location center = new _GUIClasses.Location();
    public AudioClip mainTheme;

    // Update is called once per frame
    void Start()
    {
        mainTheme = Resources.Load("mainTheme.mp3") as AudioClip);
        Debug.Log(mainTheme.name);
        //AudioSource.PlayClipAtPoint(mainTheme, new Vector3(2, 1, 2));
    }

    void Update()
    {
        center.updateLocation();
    }

    void OnGUI()
    {
        GUI.skin = racingGUISkin;
        GUI.depth = -1;
        GUI.backgroundColor = Color.clear;

        //GUI.Label(new Rect(center.offset.x, center.offset.y, 140, 50), "Hello World!");
        if (GUI.Button(new Rect(center.offset.x + buttonStartLocation.x, center.offset.y + buttonStartLocation.y, 250, 50), "START"))
        {
            Application.LoadLevel("GameScene");
        }

        if (GUI.Button(new Rect(center.offset.x + buttonExitLocation.x, center.offset.y + buttonExitLocation.y, 250, 50), "EXIT"))
        {
            Application.Quit();
        }
    }

}

