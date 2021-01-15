using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador2 : Gerador
{

    PointsSystem sistemaPontos;
    
    private void Start()
    {
        
    }

    public Gerador2(PointsSystem sistemaPontos)
    {
        geradorAntigo = GameObject.Find("Gerenciador").GetComponent<HudScript>().Geradores[0];
        this.sistemaPontos = sistemaPontos;        
        custoInicial = geradorAntigo.custoInicial;
        custoInicial += (geradorAntigo.custoInicial * Mathf.Log(2, 3)) * 2;
        tempo = 5.4f;
        GPS = geradorAntigo.GPS;
        GPS += geradorAntigo.GPS * Mathf.Log(2, 3.2f);
        this.nome = " Ferramentas";
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
            tempo = 5.4f;
        }
    }
}
