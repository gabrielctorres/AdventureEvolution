using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador7 : Gerador
{
    PointsSystem sistemaPontos;
    
    public Gerador7(PointsSystem sistemaPontos)
    {
        geradorAntigo = GameObject.Find("Gerenciador").GetComponent<HudScript>().Geradores[5];
        this.sistemaPontos = sistemaPontos;
        custoInicial = geradorAntigo.custoInicial;
        custoInicial += (geradorAntigo.custoInicial * Mathf.Log(2, 3)) * 2;
        tempo = 20.2f;
        GPS = geradorAntigo.GPS;
        GPS += geradorAntigo.GPS * Mathf.Log(2, 3.2f);
        this.nome = " Minerio de Bronze";
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
            tempo = 20.2f;
        }
    }
}
