using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{
    public GameObject spawnPoint,spawnPoint2;
    public GameObject personagem;

    DialogueTrigger triggerDialogue;

    GameObject personagemInstanciado,personagemInstanciado2;

    HudScript hudManager;
    // Start is called before the first frame update
    void Start()
    {
        hudManager = GameObject.Find("Gerenciador").GetComponent<HudScript>();
        triggerDialogue = GameObject.Find("Gerenciador").GetComponent<DialogueTrigger>();

        if (triggerDialogue.dialogue.name == "Tutorial")
        {
            triggerDialogue.TriggerDialogue();
        }


       
    }

    // Update is called once per frame
    void Update()
    {
    
        if(hudManager.Geradores[0].quantidade == 1)
        {            
            if(personagemInstanciado == null)
            {
                personagemInstanciado = Instantiate(personagem, spawnPoint.transform.position, Quaternion.identity);
                personagemInstanciado.GetComponent<Animator>().SetBool("play", true);
            }

        }else if(hudManager.Geradores[0].quantidade == 2)
        {            
            if (personagemInstanciado2 == null)
            {
                personagemInstanciado2 = Instantiate(personagem, spawnPoint2.transform.position, Quaternion.identity);
                personagemInstanciado2.GetComponent<SpriteRenderer>().flipX = true;
                personagemInstanciado2.GetComponent<Animator>().SetBool("play", true);
            }
        }
    }
}
