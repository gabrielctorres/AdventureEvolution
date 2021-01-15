using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador8 : Gerador
{
    PointsSystem sistemaPontos;
    
    
    public Gerador8(PointsSystem sistemaPontos)
    {
        geradorAntigo = GameObject.Find("Gerenciador").GetComponent<HudScript>().Geradores[6];
        this.sistemaPontos = sistemaPontos;
        custoInicial = geradorAntigo.custoInicial;
        custoInicial += (geradorAntigo.custoInicial * Mathf.Log(2, 3)) * 2;
        tempo = 24.0f;
        GPS = geradorAntigo.GPS;
        GPS += geradorAntigo.GPS * Mathf.Log(2, 3.2f);
        this.nome = " Minerio de Ferro";
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
            tempo = 24.0f;
        }
    }
}
