using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Options : MonoBehaviour
{
    [SerializeField] plantillatexto plantilla;
    [SerializeField] plantillatexto[] arrayPlantillas;

    [SerializeField] TextMeshProUGUI textoNarracion;
    [SerializeField] TextMeshProUGUI textoRespuestaUno;
    [SerializeField] TextMeshProUGUI textoRespuestaDos;
    [SerializeField] TextMeshProUGUI textoRespuestaTres;

    [SerializeField] GameObject[] arrayBotones;
    [SerializeField] string cuartos;

    // Start is called before the first frame update
    private void Start()
    {
        plantilla = arrayPlantillas[0];
        muestratexto();
    }
   
    void muestratexto()
    {
        textoNarracion.text = plantilla.textoNarrativo;
        textoRespuestaUno.text = plantilla.respuestaUno;
        textoRespuestaDos.text = plantilla.respuestaDos;
        textoRespuestaTres.text = plantilla.respuestaTres;
    }

    public void controlBotones(int indice)
    {
        if (arrayPlantillas == null || indice >= arrayPlantillas.Length)
        {
            Debug.LogError("El índice es inválido o el arreglo arrayPlantillas es nulo.");
            return;
        }

        if (plantilla.arrayReferencias == null || indice >= plantilla.arrayReferencias.Length)
        {
            Debug.LogError("El índice es inválido o el arreglo plantilla.arrayReferencias es nulo.");
            return;
        }

        plantilla = arrayPlantillas[plantilla.arrayReferencias[indice]];
        if (plantilla.quitarBotones == true)
        {
            DesactivarBotones();
        }
        muestratexto();
    }
    
    void DesactivarBotones()
    {
        foreach (var boton in arrayBotones)
        {
            boton.SetActive(false);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Game");
        }
    }

}
