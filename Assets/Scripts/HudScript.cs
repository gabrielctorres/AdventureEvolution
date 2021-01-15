using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class HudScript : MonoBehaviour
{
    TextMeshProUGUI txtCurrency;
    PointsSystem pointsSystem;

    public ControladorGeradores controleGeradores;

    public Sentences DialogoPeriodo1;
    public Sentences DialogoPeriodo2;
    public Sentences DialogoPeriodo3;

    DialogueTrigger Dialogue;

    int index = 1;
    int index2 = 1;
    int index3 = 1;
    int index4 = 1;
    int index5 = 1;
    int index6 = 1;
    int index7 = 1;
    int index8 = 1;
    public GameObject imgHistoriador;
    public bool storeOpen;

    
    public GameObject game,store;
    
    public List<Gerador> Geradores = new List<Gerador>();

    [Header("Textos De Preco")]
    public List<TextMeshProUGUI> txtPrices = new List<TextMeshProUGUI>();
    [Header("Textos De Nomes")]
    public List<TextMeshProUGUI> txtNames = new List<TextMeshProUGUI>();
    [Header("Textos De Ganhos")]
    public List<TextMeshProUGUI> txtGanhos = new List<TextMeshProUGUI>();

  
  

    void Start()
    {
        
        game.SetActive(true);
        store.SetActive(false);
        txtCurrency = GameObject.Find("txtIdeiasHud").GetComponent<TextMeshProUGUI>();
        pointsSystem = GameObject.Find("Gerenciador").GetComponent<PointsSystem>();
        controleGeradores = GameObject.Find("Gerenciador").GetComponent<ControladorGeradores>();
        
        Dialogue = GameObject.Find("Gerenciador").GetComponent<DialogueTrigger>();

        Geradores.Add(new Gerador1(pointsSystem));        
        Geradores.Add(new Gerador2(pointsSystem));        
        Geradores.Add(new Gerador3(pointsSystem));
        Geradores.Add(new Gerador4(pointsSystem));
        Geradores.Add(new Gerador5(pointsSystem));
        Geradores.Add(new Gerador6(pointsSystem));
        Geradores.Add(new Gerador7(pointsSystem));
        Geradores.Add(new Gerador8(pointsSystem));
    }
    void Update()
    {
        AtualizarTextCurrency();

        for (int i = 0; i < Geradores.Count; i++)
        {
            txtNames[i].text = Geradores[i].quantidade.ToString() + "x " + Geradores[i].nome;
            txtGanhos[i].text = "Ganho: " + Geradores[i].GPS.ToString("F2") + " / " + Geradores[i].tempo.ToString("n0") + "s";
            txtPrices[i].text = Geradores[i].custoInicial.ToString("F2");
        }

    }

    public void openStore()
    {
        storeOpen = true;
        game.SetActive(false);
        store.SetActive(true);
    }

    public void closeStore()
    {
        storeOpen = false;
        game.SetActive(true);
        store.SetActive(false);
    }   


    public void AtualizarTextCurrency()
    {
        txtCurrency.text = pointsSystem.primaryCurrency.ToString("F2");

        if(pointsSystem.primaryCurrency > 1000)
        {
            var expoente = (Mathf.Floor(Mathf.Log10(System.Math.Abs(pointsSystem.primaryCurrency))));
            var valor = (pointsSystem.primaryCurrency / System.Math.Pow(10, expoente));
            txtCurrency.fontSize = 70f;
            txtCurrency.text = valor.ToString("F2") + "K";
        }

        if (pointsSystem.primaryCurrency > 1000000)
        {
            var expoente = (Mathf.Floor(Mathf.Log10(System.Math.Abs(pointsSystem.primaryCurrency))));
            var valor = (pointsSystem.primaryCurrency / System.Math.Pow(10, expoente));
            txtCurrency.fontSize = 65f;
            txtCurrency.text = valor.ToString("F2") + "M";
        }

    }


    public void btnGerador1()
    {
        if (pointsSystem.primaryCurrency >= Geradores[0].custoInicial)
        {
            

            if (index == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f,3f);
                imgHistoriador.SetActive(true);
                Dialogue.dialogue.sentences = DialogoPeriodo1.senteces;
                Dialogue.TriggerDialogue();
                
                index = 2;
            }
 
            Geradores[0].quantidade++;            
            controleGeradores.AdicionarGerador(Geradores[0]);
            pointsSystem.primaryCurrency -= Geradores[0].custoInicial;
            Geradores[0].custoInicial += Geradores[0].custoInicial * Mathf.Log(2f,10f);
        }      

    }

    public void btnGerador2()
    {


        if (pointsSystem.primaryCurrency >= Geradores[1].custoInicial)
        {
            

            if (index2 == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f, 3f);
                index2 = 2;
            }


            Geradores[1].quantidade++;            
            controleGeradores.AdicionarGerador(Geradores[1]);
            pointsSystem.primaryCurrency -= Geradores[1].custoInicial;
            Geradores[1].custoInicial += Geradores[1].custoInicial * Mathf.Log(2f, 10f);
        }
    }

    public void btnGerador3()
    {
        if (pointsSystem.primaryCurrency >= Geradores[2].custoInicial)
        {
            

            if (index3 == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f, 3f);
                index3 = 2;
            }


            Geradores[2].quantidade++;            
            controleGeradores.AdicionarGerador(Geradores[2]);
            pointsSystem.primaryCurrency -= Geradores[2].custoInicial;
            Geradores[2].custoInicial += Geradores[2].custoInicial * Mathf.Log(2f, 10f);
        }
    }

    public void btnGerador4()
    {
        if (pointsSystem.primaryCurrency >= Geradores[3].custoInicial)
        {
            

            if (index4 == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f, 3f);
                imgHistoriador.SetActive(true);
                Dialogue.dialogue.sentences = DialogoPeriodo2.senteces;
                Dialogue.TriggerDialogue();
                index4 = 2;
            }


            Geradores[3].quantidade++;
            controleGeradores.AdicionarGerador(Geradores[3]);
            pointsSystem.primaryCurrency -= Geradores[3].custoInicial;
            Geradores[3].custoInicial += Geradores[3].custoInicial * Mathf.Log(2f, 10f);
        }
    }

    public void btnGerador5()
    {
        if (pointsSystem.primaryCurrency >= Geradores[4].custoInicial)
        {


            if (index5 == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f, 3f);
                index5 = 2;
            }


            Geradores[4].quantidade++;
            controleGeradores.AdicionarGerador(Geradores[4]);
            pointsSystem.primaryCurrency -= Geradores[4].custoInicial;
            Geradores[4].custoInicial += Geradores[4].custoInicial * Mathf.Log(2f, 10f);
        }
    }

    public void btnGerador6()
    {
        if (pointsSystem.primaryCurrency >= Geradores[5].custoInicial)
        {


            if (index6 == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f, 3f);
                imgHistoriador.SetActive(true);
                Dialogue.dialogue.sentences = DialogoPeriodo3.senteces;
                Dialogue.TriggerDialogue();
                index6 = 2;
            }


            Geradores[5].quantidade++;
            controleGeradores.AdicionarGerador(Geradores[5]);
            pointsSystem.primaryCurrency -= Geradores[5].custoInicial;
            Geradores[5].custoInicial += Geradores[5].custoInicial * Mathf.Log(2f, 10f);
        }
    }
    public void btnGerador7()
    {
        if (pointsSystem.primaryCurrency >= Geradores[5].custoInicial)
        {


            if (index7 == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f, 3f);
                index7 = 2;
            }


            Geradores[5].quantidade++;
            controleGeradores.AdicionarGerador(Geradores[5]);
            pointsSystem.primaryCurrency -= Geradores[5].custoInicial;
            Geradores[5].custoInicial += Geradores[5].custoInicial * Mathf.Log(2f, 10f);
        }
    }

    public void btnGerador8()
    {
        if (pointsSystem.primaryCurrency >= Geradores[6].custoInicial)
        {


            if (index8 == 1)
            {
                pointsSystem.EPC += pointsSystem.EPC * Mathf.Log(2f, 3f);
                index8 = 2;
            }


            Geradores[6].quantidade++;
            controleGeradores.AdicionarGerador(Geradores[6]);
            pointsSystem.primaryCurrency -= Geradores[6].custoInicial;
            Geradores[6].custoInicial += Geradores[6].custoInicial * Mathf.Log(2f, 10f);
        }
    }
}
