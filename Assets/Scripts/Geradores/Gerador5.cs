using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador5 : Gerador
{
    PointsSystem sistemaPontos;
    Gerador geradorAntigo;
    public Gerador5(PointsSystem sistemaPontos)
    {
        geradorAntigo = GameObject.Find("Gerenciador").GetComponent<HudScript>().Geradores[3];
        this.sistemaPontos = sistemaPontos;
        custoInicial = geradorAntigo.custoInicial;
        custoInicial += (geradorAntigo.custoInicial * Mathf.Log(2, 3)) * 2;
        tempo = 13.5f;
        GPS = geradorAntigo.GPS;
        GPS += geradorAntigo.GPS * Mathf.Log(2, 3.2f);
        this.nome = " Pedra Polida";
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
            tempo = 13.5f;
        }
    }
}
