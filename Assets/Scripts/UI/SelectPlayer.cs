using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPlayer : MonoBehaviour {

    public GameObject BikeFirst
    {
        get { return bikeFirst; }
        set { bikeFirst = value; }
    }
    [SerializeField]
    private GameObject bikeFirst;

    public GameObject BikeSecond
    {
        get { return bikeSecond; }
        set { bikeSecond = value; }
    }
    [SerializeField]
    private GameObject bikeSecond;

    public GameObject BikeThird
    {
        get { return bikeThird; }
        set { bikeThird = value; }
    }
    [SerializeField]
    private GameObject bikeThird;

    private GameObject CurrentBike;


    public Button Change
    {
        get { return change; }
        set { change = value; }
    }
    [SerializeField]
    private Button change;

    private Vector3 ShowBike = new Vector3(4, -0.76f, 86);
    private Vector3 HiddenBike = new Vector3(15, -0.76f, 86);


    private bool changePress;

    [SerializeField]
    private float speedTranslate;


    private void Start()
    {
        LoadResources();
    }


    private void LoadResources()
    {
        changePress = false;

        //BIKE 1 COMEÇA SETADA
        CurrentBike = bikeFirst;    
         
    }


    public void ChangePress()
    {
        ChangeBike();
        changePress = true;
        
    }

    //AQUI VAI DECIDIR QUAL BIKE FICA 
   private void ChangeBike()
    {
        if (CurrentBike == bikeFirst)
        {
            CurrentBike = bikeSecond;   
        }
        else if (CurrentBike == bikeSecond)
        {
            CurrentBike = bikeThird;
        }
        else
        {
            CurrentBike = bikeFirst;   
        }
    }


    private void Update()
    {
        if (changePress)
        {
            MoveMainBike(VerifyBike());
        }
    }

   
    private GameObject VerifyBike()
    {
        if (CurrentBike == bikeFirst)
        {
            
            return bikeFirst;
        }
        else if (CurrentBike == bikeSecond)
        {

            return bikeSecond;
        }
        else
        {

            return bikeThird;
        }


    }


    private void MoveMainBike(GameObject mainBike)
    {
        mainBike.transform.position = Vector3.Lerp(mainBike.transform.position, ShowBike, speedTranslate * Time.deltaTime);

        ReturnPosition(mainBike);

    }


    private void ReturnPosition(GameObject mainBike)
    {
        if (mainBike != bikeFirst)
        {
            bikeFirst.transform.position = Vector3.Lerp(bikeFirst.transform.position, HiddenBike, speedTranslate * Time.deltaTime);
        }
        if (mainBike != bikeSecond)
        {
            bikeSecond.transform.position = Vector3.Lerp(bikeSecond.transform.position, HiddenBike, speedTranslate * Time.deltaTime);
        }
        if (mainBike != bikeThird)
        {
            bikeThird.transform.position = Vector3.Lerp(bikeThird.transform.position, HiddenBike, speedTranslate * Time.deltaTime);
        }
    }


}
