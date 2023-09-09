using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ModifTime : MonoBehaviour
{
    public TextMeshProUGUI hora;
    public TextMeshProUGUI minuto;

    private void Start()
    {
        // Llama a la función ActualizarHora cada segundo y repite la llamada cada segundo
        InvokeRepeating("ActualizarHora", 1f, 1f);
    }

    private void ActualizarHora()
    {
        // Obtiene la fecha y hora actual del sistema
        DateTime now = DateTime.Now;

        // Obtiene la hora, los minutos y los segundos de la fecha y hora actual
        int hour = now.Hour;
        int minute = now.Minute;

        hora.text = hour.ToString();
        minuto.text = minute.ToString();
    }
}
