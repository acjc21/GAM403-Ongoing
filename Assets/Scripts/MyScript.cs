using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float playerspeed;
    public float speedburst = 2;
   public int ammo = 100;
    public int health = 100;

    public float playerAccuracyForThisMatch = 15.5f;

    public string player = "Jc";

    public Vector3 starting;

    // Start is called before the first frame update
    void Start()
    {
        ammo = ammo + 20;

        Debug.Log("My Ammo Is: " + ammo);
        transform.position = starting;
    }

    // Update is called once per frame
    void Update()
    {
        playerspeed = playerspeed + speedburst;

        //Moves out player in the forward direction every frame by player speed


        transform.Translate(Vector3.forward * playerspeed * speedburst);
    }
}
