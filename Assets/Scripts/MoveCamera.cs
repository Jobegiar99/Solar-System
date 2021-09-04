using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        if( Input.mousePosition.x <= (Screen.width * 0.15f) )
        {
            float rotateSpeed = (Input.mousePosition.x <= (Screen.width * 0.05f)) ? -0.15f : -0.05f;
            transform.Rotate(new Vector3(0, rotateSpeed, 0));

        }
        else if( Input.mousePosition.x > (Screen.width * 0.85f))
        {
            float rotateSpeed = (Input.mousePosition.x <= (Screen.width * 0.95f)) ? 0.05f : 0.15f;
            transform.Rotate(new Vector3(0, rotateSpeed, 0));
        }

        else if (Input.mousePosition.y <= (Screen.height * 0.15f))
        {
            float rotateSpeed = (Input.mousePosition.y <= (Screen.height * 0.05f)) ? 0.15f : 0.05f;
            transform.Rotate(new Vector3(rotateSpeed, 0, 0));

        }
        else if (Input.mousePosition.y > (Screen.height * 0.85f))
        {
            float rotateSpeed = (Input.mousePosition.y <= (Screen.height * 0.95f)) ? -0.05f :- 0.15f;
            transform.Rotate(new Vector3(rotateSpeed, 0, 0));
        }


        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 0.006f ;


        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward  * 0.006f;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 0.006f;

        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * 0.006f;

        }
        GameObject minimapCamera = GameObject.Find("Minimap Camera");

        minimapCamera.transform.position = new Vector3(transform.position.x,minimapCamera.transform.position.y, transform.position.z) ;




    }
}
