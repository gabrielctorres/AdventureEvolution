using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsSystem : MonoBehaviour
{
    public float primaryCurrency;

    public ParticleSystem particulaPoints;

    public DialogueManager dialogoManager;

    HudScript hud;

    public float EPC = 2.0f; //Earnings Per Click   

   

    private void Start()
    {
        
        hud = GameObject.Find("Gerenciador").GetComponent<HudScript>();
       
    }


    public void Click()
    {
        primaryCurrency += EPC;
        
        Debug.Log(EPC);
    }

    private void Update()
    {
        TouchOnScreen();
    }
    void TouchOnScreen()
    {
       
        if (Input.GetMouseButtonDown(0) && hud.storeOpen == false && dialogoManager.DialogoAtivo == false)
        {
            var touch = Input.GetMouseButtonDown(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.y > -4f)
            {
                Click();               
                ParticleSystem ParticulaInstanciada = Instantiate(particulaPoints, touchPos, Quaternion.identity);
                ParticulaInstanciada.Play();
            }
        }
    }

}
