using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_me : MonoBehaviour
{ 
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;

    // Start is called before the first frame update
    void Start()
    { 
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        
    }

    // Update is called once per frame
    void Update()
    {  JointSpring spring = new JointSpring ();
    spring.spring =  hitStrength;
    spring.damper = flipperDamper;

        if(inputName == "RFlipper")
        {
            if (Input.GetKey(KeyCode.D))
            {
                spring.targetPosition = pressedPosition;            }
            else
            {
                spring.targetPosition = restPosition;
            }


        } else if (inputName == "LFlipper")
        {
            if (Input.GetKey(KeyCode.A))
            {
                spring.targetPosition = pressedPosition;
            }
            else
            {
                spring.targetPosition = restPosition;
            }
        }
        hinge.spring = spring;
        hinge.useLimits = true;



        /*
        if (Input.GetAxis(inputName)==1)
        {
            spring.targetPosition = pressedPosition;
        }
        else {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
        */
    }
}