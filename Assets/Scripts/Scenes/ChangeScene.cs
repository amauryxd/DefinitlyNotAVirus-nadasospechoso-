using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string nombreDeEscenaDestino;
    public float tiempoEspera = 5f;
    private float tiempoTranscurrido = 0f;
    private bool cambioIniciado = false;
    void Update()
    {
        if (!cambioIniciado)
        {
            tiempoTranscurrido += Time.deltaTime;

            if (tiempoTranscurrido >= tiempoEspera)
            {
                // Cambia a la escena de destino después de 5 segundos.
                SceneManager.LoadScene(nombreDeEscenaDestino);
                cambioIniciado = true;
            }
        }
    }
}
