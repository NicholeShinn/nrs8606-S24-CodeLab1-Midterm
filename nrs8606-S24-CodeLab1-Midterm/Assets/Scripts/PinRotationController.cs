using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PinRotationController : MonoBehaviour
{
    Rigidbody groundRigidbody;
    public GameObject groundObject;

    //defining torque variable
    public float torqueAmount = 2;
    public float axisXRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        //getting the rigidbody component from ground to use physics with
        groundRigidbody = GetComponent <Rigidbody> ();
        axisXRotation = groundObject.transform.rotation.x;
    }

    // Update is called once per frame
    void Update()
    { 
        //Couldn't clamp the x axis rotation....with the below code
        //axisXRotation = Mathf.Clamp(groundObject.transform.rotation.x, -100, 100);
        
        //rotating the plane cube using torque on the rigidbody. Reversed for some reason?
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //WASD code but with Torque instead of Force
            groundRigidbody.AddTorque(Vector3.up * torqueAmount);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            groundRigidbody.AddTorque(Vector3.down * torqueAmount);
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            groundRigidbody.AddTorque(Vector3.left * torqueAmount);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            groundRigidbody.AddTorque(Vector3.right * torqueAmount);
        }
        
        

    }
}
