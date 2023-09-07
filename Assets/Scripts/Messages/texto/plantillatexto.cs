using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "objetoTexto")]
public class plantillatexto : ScriptableObject
{
    [TextArea(3, 15)]
    public string textoNarrativo;

    [Space(20)]
    public string respuestaUno;
    public string respuestaDos;

    [Space(20)]
    public int[] arrayReferencias = new int[3];

    [Space(20)]
    public bool quitarBotones;

}
