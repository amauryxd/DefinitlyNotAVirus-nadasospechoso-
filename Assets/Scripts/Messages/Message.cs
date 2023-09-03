using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Message : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed = 0.1f;
    int index;

    public string sceneName;

    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            NextScene();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else
        {
            // Aquí puedes realizar alguna acción adicional una vez que se hayan mostrado todos los diálogos.
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(sceneName); // Reemplaza "NombreDeTuSiguienteEscena" con el nombre de la escena a la que deseas cambiar.
    }
}
