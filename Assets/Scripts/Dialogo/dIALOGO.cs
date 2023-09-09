using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class dIALOGO : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguepanel;
    [SerializeField] private Text text;
    private Story curretstory;
    private static dIALOGO instance;
    private bool dialogueIsPlaying;
     
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Found more dialogue managerunu");
        }
        instance = this;
    }

    public static dIALOGO GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguepanel.SetActive(false);
    }
    private void Update()
    {
        //regresar si no hay texto corriendo
        if(!dialogueIsPlaying)
        {
            return;
        }

        if (DialogueManager.presionado == true)//DialogueManager.presionado == true)
        {
            Debug.Log(DialogueManager.presionado);
            ContinueStory();
            
        }
        
    }
    public void Enterdialoguemode(TextAsset inkJSON)
    {
        curretstory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguepanel.SetActive(true);
        ContinueStory();
       
    }
    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguepanel.SetActive(false);
        text.text = "";
    }
    private void ContinueStory()
    {
        if (curretstory.canContinue)
        {
            text.text = curretstory.Continue();
        }
        else
        {
            ExitDialogueMode();
        }
    }
}
