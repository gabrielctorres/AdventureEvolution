using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador3 : Gerador
{
    PointsSystem sistemaPontos;
    

    public Gerador3(PointsSystem sistemaPontos)
    {
        geradorAntigo = GameObject.Find("Gerenciador").GetComponent<HudScript>().Geradores[1];
        this.sistemaPontos = sistemaPontos;
        custoInicial = geradorAntigo.custoInicial;
        custoInicial += (geradorAntigo.custoInicial * Mathf.Log(2, 3)) * 2;
        tempo = 7.0f;
        GPS = geradorAntigo.GPS;
        GPS += geradorAntigo.GPS * Mathf.Log(2, 3.2f);
        this.nome = " Comida";
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
            tempo = 7.0f;
        }
    }
}
