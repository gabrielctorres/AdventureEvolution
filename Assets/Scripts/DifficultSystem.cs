using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultSystem : MonoBehaviour
{
    PointsSystem pointsSystem;
    HudScript hudScript;
    public List<float> precoGeradores = new List<float>();
    int difficult;
    public float timer = 8.56f;
    // Start is called before the first frame update
    void Start()
    {
        pointsSystem = GameObject.Find("Gerenciador").GetComponent<PointsSystem>();
        hudScript = GameObject.Find("Gerenciador").GetComponent<HudScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }else if( timer < 0)
        {
            timer = 0;
        }

        Debug.Log(timer);
        if(timer > 0 && pointsSystem.primaryCurrency >= 145.78f)
        {
            for (int k = 0; k < hudScript.Geradores.Count; k++)
            {
                hudScript.Geradores[k].custoInicial = precoGeradores[k];                
            }
            timer = 0f;
        }
    }
}
