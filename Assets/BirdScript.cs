using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //RigidBody > info > Linear / Angular Velocity is initially greyed out , we can enable it in our script
    //by creating a reference
    public Rigidbody2D myrigidBody; //public so we can access this from outside the script
    public float flapStrength;
    public LogicScript logic;
    public bool birdAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // as soon as the script is enabled and runs precisely ONCE
    void Start()
    {
        // gameObject.name = "MoodyOwl";
    }

    // Update is called once per frame
    // While script is enabled , it runs continuously , fires every line of code , every single frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)== true && birdAlive)
        {
            myrigidBody.linearVelocity = Vector2.up * flapStrength;
        }      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive=false;
    }
}
