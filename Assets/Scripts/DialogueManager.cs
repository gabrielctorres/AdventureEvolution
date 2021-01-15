using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI textArea;
    private Queue<string> sentences = new Queue<string>();  
    public bool DialogoAtivo = false;
    public GameObject imgHistoriador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartDialogue (Dialogue dialogue)
    {
        
        imgHistoriador.SetActive(true);
        DialogoAtivo = true;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }


    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
       string sentence = sentences.Dequeue();
       StopAllCoroutines();
       StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        textArea.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textArea.text += letter;
            yield return null;
        }
    }


    void EndDialogue()
    {     
     
        imgHistoriador.SetActive(false);
        DialogoAtivo = false;
    }

}
