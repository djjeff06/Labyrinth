using UnityEngine;
using System.Collections;

public class GroundMove : MonoBehaviour {

    private int hor;
    private int ver;

	// Use this for initialization
	void Start () {

        hor = 0;
        ver = 0;

	}
	
	// Update is called once per frame
	void Update () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        int maxRotate = 20;

        var rotationVector = transform.rotation.eulerAngles;

        if (moveHorizontal < 0 && rotationVector.z < maxRotate)
        {
            rotationVector.z++;
            hor--;
            transform.rotation = Quaternion.Euler(rotationVector);

        }
        else if (moveHorizontal > 0 && hor<maxRotate)
        {
            rotationVector.z--;
            hor++;
            transform.rotation = Quaternion.Euler(rotationVector);

        }

        else if(moveVertical > 0 && rotationVector.x < maxRotate)
        {

            rotationVector.x++;
            ver++;
            transform.rotation = Quaternion.Euler(rotationVector);

        }

        else if(moveVertical < 0 && ver>-20)
        {

            rotationVector.x--;
            ver--;
            transform.rotation = Quaternion.Euler(rotationVector);

        }

        else if(ver > 0)
        {

            rotationVector.x--;
            ver--;
            transform.rotation = Quaternion.Euler(rotationVector);

        }

        else if(ver < 0)
        {

            rotationVector.x++;
            ver++;
            transform.rotation = Quaternion.Euler(rotationVector);

        }

        else if (hor < 0)
        {

            rotationVector.z--;
            hor++;
            transform.rotation = Quaternion.Euler(rotationVector);

        }
 
        else if(hor > 0)
        {

            rotationVector.z++;
            hor--;
            transform.rotation = Quaternion.Euler(rotationVector);

        }

    }
}
