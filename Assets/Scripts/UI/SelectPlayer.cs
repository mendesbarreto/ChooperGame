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

    private GameObject CurrentBike;

    //UI
    public Button Change
    {
        get { return change; }
        set { change = value; }
    }
    [SerializeField]
    private Button change;

    //PROPRIEDADES
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
        if (CurrentBike == bikeFirst)
        {
            CurrentBike = bikeSecond;
            MainGame.instance.CurrentObject = 1; //YELLOW
        }
        else if (CurrentBike == bikeSecond)
        {
            CurrentBike = bikeThird;
            MainGame.instance.CurrentObject = 2; //BLUE
        }
        else
        {
            CurrentBike = bikeFirst;
            MainGame.instance.CurrentObject = 0; //RED 
        }
    }

   //VERIFICA BIKE SETADA
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

    //MOVE PARA O PAINEL
    private void MoveMainBike(GameObject mainBike)
    {
        mainBike.transform.position = Vector3.Lerp(mainBike.transform.position, ShowBike, speedTranslate * Time.deltaTime);
        ReturnPosition(mainBike);
    }

    //RETIRA DO PAINEL 
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
