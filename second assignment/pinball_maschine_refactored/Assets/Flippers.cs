using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 100000;
    public float flipperDamper = 150f;
    HingeJoint hinge;

    public bool inputRight;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {

        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;


        if (inputRight)
        {
            if (Input.GetKey(KeyCode.D))
            {
                spring.targetPosition = pressedPosition;

            }
            else
            {
                spring.targetPosition = restPosition;
            }
        }
        else
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
    }
}

//Code for HingeJoint from Youtube Tutorial: https://www.youtube.com/watch?v=y7WgV8-yfcI by NejoFTW (last checked on 20.11.2022)


/*Instructor work:
Set Hinges with arrow up

Work for right flipper:

(Hinge) Limits: 
    Min: -45
    Max: 0

Motor Use Limits: true

Rest Position: 0
Pressed Position: -45
Hit Strengh: 100000



Work for left flipper:

(Hinge) Limits: 
    Min: 0
    Max: 45

Motor Use Limits: true

Rest Position: 0
Pressed Position: 45
Hit Strengh: 100000
*/



