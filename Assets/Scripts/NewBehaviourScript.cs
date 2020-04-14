using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed;
    public Rigidbody2D body;
    private float thrust = 111f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello: Start");
      //  speed = 1;
       // body.rotation = 90f;
       // transform.position = new Vector3(3.0f, 5.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 thrustvector = new Vector2(0,333f);

        //body.AddForce(thrustvector);

        if (Input.GetKeyDown(KeyCode.S))
        {
            body.rotation = 0f;
            transform.position = new Vector3(0, -0.82f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
       {
            Debug.Log("space bar " +  thrust + " : " + transform.up);
            body.AddForce(transform.up *  thrust);
           // body.AddForce(thrustvector);
        }

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // body.velocity = new Vector2(h * speed, v * speed);

        float torque = -(h / 4);
        float rotation = body.rotation;

        if (rotation>5f || rotation<-5f)
        {
            torque = (h / 6);
        }


        body.AddTorque(torque);

        // body.rotation = 90f;
    }
}

public class Movement : MonoBehaviour
{
    public float speed;
}
