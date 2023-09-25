using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubo : MonoBehaviour
{
    public Image image;
    public GameObject archivo;
    // Start is called before the first frame update
    void Start()
    {
        image = archivo.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        //Debug.Log(archivo.transform.position);
        if (archivo.transform.position.y > 867 && archivo.transform.position.y < 996 && archivo.transform.position.x > 65 && archivo.transform.position.x < 158)// && Input.GetMouseButton(0) == false) 
        {
            

           image.color = new Color(image.color.r, image.color.g, image.color.b, 0.5f);
            
            if (Input.GetMouseButton(0) == false)
            {
                archivo.GetComponent<ElminarObjeto>().desaparecer();
            }
        }
    }

}
