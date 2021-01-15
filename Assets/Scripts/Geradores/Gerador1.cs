using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador1 : Gerador
{

    PointsSystem sistemaPontos;   

    public Gerador1(PointsSystem sistemaPontos)
    {
        
        this.sistemaPontos = sistemaPontos;       
        custoInicial = 155f;
        tempo = 2f;
        GPS = 0.4f;
        this.nome = " Nomades";
    }

    private void Update()
    {
        GerarIdeias();
    }

    public override void GerarIdeias()
    {
   
        tempo -= Time.deltaTime;        
        if (tempo <= 0)
        {            
            sistemaPontos.primaryCurrency += GPS * quantidade;            
            tempo = 2;
        }
    }
}
