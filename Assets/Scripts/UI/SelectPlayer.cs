using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class SelectPlayer : MonoBehaviour {
    
    //BIKES
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

    private GameObject currentBike;

    //UI
    public Button Change
    {
        get { return change; }
        set { change = value; }
    }
    [SerializeField]
    private Button change;

    //PROPRIEDADES
    private Vector3 showBike = new Vector3(4, -0.76f, 86);
    private Vector3 hiddenBike = new Vector3(15, -0.76f, 86);
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
        currentBike = bikeFirst;
        MainGame.instance.CurrentObject = 0; //RED
          
    }

    public void ChangePress()
    {
        ChangeBike();
        changePress = true;
        
    }

    private void Update()
    {
        if (changePress)
        {
            MoveMainBike(VerifyBike());
        }
    }

    //AQUI VAI DECIDIR QUAL BIKE FICA 
    private void ChangeBike()
    {
        if (currentBike == bikeFirst)
        {
            currentBike = bikeSecond;
            MainGame.instance.CurrentObject = 1; //YELLOW
        }
        else if (currentBike == bikeSecond)
        {
            currentBike = bikeThird;
            MainGame.instance.CurrentObject = 2; //BLUE
        }
        else
        {
            currentBike = bikeFirst;
            MainGame.instance.CurrentObject = 0; //RED 
        }
    }

   //VERIFICA BIKE SETADA
    private GameObject VerifyBike()
    {
        if (currentBike == bikeFirst)
        {  
            return bikeFirst;
        }
        else if (currentBike == bikeSecond)
        {
            return bikeSecond;
        }
        else
        {
            return bikeThird;
        }


    }

    //MOVE PARA O PAINEL
    private void MoveMainBike(GameObject mainBike)
    {
        mainBike.transform.position = Vector3.Lerp(mainBike.transform.position, showBike, speedTranslate * Time.deltaTime);
        ReturnPosition(mainBike);
    }

    //RETIRA DO PAINEL 
    private void ReturnPosition(GameObject mainBike)
    {
        if (mainBike != bikeFirst)
        {
            bikeFirst.transform.position = Vector3.Lerp(bikeFirst.transform.position, hiddenBike, speedTranslate * Time.deltaTime);
        }
        if (mainBike != bikeSecond)
        {
            bikeSecond.transform.position = Vector3.Lerp(bikeSecond.transform.position, hiddenBike, speedTranslate * Time.deltaTime);
        }
        if (mainBike != bikeThird)
        {
            bikeThird.transform.position = Vector3.Lerp(bikeThird.transform.position, hiddenBike, speedTranslate * Time.deltaTime);
        }
    }

}
