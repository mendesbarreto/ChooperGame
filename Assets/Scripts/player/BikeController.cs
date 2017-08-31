using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BikeController : MonoBehaviour {

    //PROPRIEDADES
    [SerializeField]
    private float speed = 3000;
    [SerializeField]
    private float rotationSpeed = 400f;
    [SerializeField]
    private WheelJoint2D backWeel;
    [SerializeField]
    private WheelJoint2D frontWeel;
    [SerializeField]
    private Rigidbody2D playerRB;

    private float movement = 0f;
    private float rotation = 0f;


    //CONTROLE
    [SerializeField]
    private bool EnablePcController;

    //MOBILE 
    public GameObject MoveFront
    {
        get { return moveFront; }
        set { moveFront = value; }
    }
    [SerializeField]
    private GameObject moveFront;

    public GameObject MoveBack
    {
        get { return moveBack; }
        set { moveBack = value; }
    }
    [SerializeField]
    private GameObject moveBack;

    public GameObject ButtonDir
    {
        get { return ButtonDir; }
        set { ButtonDir = value; }
    }
    [SerializeField]
    private GameObject buttonDir;

    public GameObject ButtonEsq
    {
        get { return ButtonEsq; }
        set { ButtonEsq = value; }
    }
    [SerializeField]
    private GameObject buttonEsq;

    private PlayerController componentFront;
    private PlayerController componentBack;
    private PlayerController componentDir;
    private PlayerController componentEsq;

    private void Start()
    {
        componentFront = moveFront.GetComponent<PlayerController>();
        componentBack = moveBack.GetComponent<PlayerController>();
        componentDir = buttonDir.GetComponent<PlayerController>();
        componentEsq = buttonEsq.GetComponent<PlayerController>();
    }



    private void Update()
    {
        if (EnablePcController == true)
        {
            PcController();
        }
        else
        {
            MobileController();
        }
        }



    private void PcController()
    {
        movement = -Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal");
    }



    private void MobileController()
    {

        if (componentFront.input == 1)
        {
            movement = -1 * speed;
        }
        else if (componentBack.input == 1)
        {
            movement = 1 * speed;
        }
        else
        {
            movement = 0f;
        }


        if (componentDir.input == 1)
        {
            rotation = 1;
        }
        else if (componentEsq.input == 1)
        {
            rotation = -1;
        }
        else
        {
            rotation = 0f;
        }
        

    }



    private void FixedUpdate()
    {
        if(movement == 0f)
        {
            backWeel.useMotor = false;
            frontWeel.useMotor = false;
        }
        else
        {
            backWeel.useMotor = true;
            frontWeel.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = backWeel.motor.maxMotorTorque };
            backWeel.motor = motor;
            frontWeel.motor = motor;
        }


        playerRB.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);


    }

}
