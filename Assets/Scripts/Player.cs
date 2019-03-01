using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Light myLight;
    public int health;
    public int HealthBonus = 10;
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        myLight.color = Color.green;
        AddToHealth();

        //Adds Full Health
        AddToHealth(100);

        //Adds Half Health
        AddToHealth(50);

        //Adds Tiny Health
        AddToHealth(10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {

            AddToHealth(1);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h,0,v)*speed);
    }
    //this adds to our health
    void AddToHealth()
    {
        health += HealthBonus;


       
    }
    void AddToHealth(int HealthModifier)
    {

    }
}
