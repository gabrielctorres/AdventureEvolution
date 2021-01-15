using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public abstract class Gerador : MonoBehaviour
{
    public string nome;
    public float custoInicial = 0;
    public float GPS = 0; // Ganhos por Segundo
    public float tempo = 0;
    public int quantidade = 0;
    public bool comprado;
    public Gerador geradorAntigo;
    public override bool Equals(object obj)
    {
        var gerador = obj as Gerador;
        return gerador != null &&
               base.Equals(obj) &&
               custoInicial == gerador.custoInicial &&
               GPS == gerador.GPS &&
               tempo == gerador.tempo &&
               quantidade == gerador.quantidade &&
               comprado == gerador.comprado &&
               nome == gerador.nome;
               
    }

    public abstract void GerarIdeias();

    public override int GetHashCode()
    {
        var hashCode = -1417836068;
        hashCode = hashCode * -1521134295 + base.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
        hashCode = hashCode * -1521134295 + custoInicial.GetHashCode();
        hashCode = hashCode * -1521134295 + GPS.GetHashCode();
        hashCode = hashCode * -1521134295 + tempo.GetHashCode();
        hashCode = hashCode * -1521134295 + quantidade.GetHashCode();
        hashCode = hashCode * -1521134295 + comprado.GetHashCode();
        return hashCode;
    }
}
