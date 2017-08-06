using UnityEngine;
using System.Collections;

public class BlackController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float xaxis = 0;
        float yaxis = 0;
        float zaxis = 0;
        if (Input.GetKey(KeyCode.I)){

            zaxis += 1;

        }
        else if (Input.GetKey(KeyCode.K))
        {

            zaxis += -1;

        }
        else if(Input.GetKey(KeyCode.J))
        {

            xaxis += -1;

        }
        else if(Input.GetKey(KeyCode.L))
        {

            xaxis += 1;

        }
        if (Input.GetKey(KeyCode.Space))
        {

            yaxis += 1;

        }

        Vector3 movement = new Vector3(xaxis, yaxis, zaxis);

        rb.AddForce(movement * speed);
    }
}