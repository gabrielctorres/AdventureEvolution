using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControladorGeradores : MonoBehaviour
{
    public List<Gerador> Geradores = new List<Gerador>();
    private void Update()
    {
        for (int i = 0; i < Geradores.Count; i++)
        {
            Geradores[i].GerarIdeias();
        }

       
    }


    public void AdicionarGerador(Gerador g)
    {
        if (Geradores.Contains(g))
        {
            int index;
            index = Geradores.IndexOf(g);
            Geradores[index].quantidade++;
        }
        else
        {
            Geradores.Add(g);
            
        }
    }

}
