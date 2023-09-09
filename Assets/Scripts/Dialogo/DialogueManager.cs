using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    public static bool presionado;
    private void Update()
    {

        PressingQ();
        presionado = false;
    }
    public void PressingQ()
    {
        if (Input.GetKeyDown("space"))
        {
           
            dIALOGO.GetInstance().Enterdialoguemode(inkJSON);
        }
    }

}
