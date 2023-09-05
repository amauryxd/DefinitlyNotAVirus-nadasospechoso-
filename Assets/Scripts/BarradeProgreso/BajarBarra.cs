using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarBarra : MonoBehaviour
{
    public static void QuitarBarra(float cantidad)
    {
        AumentarBarra.progAct = AumentarBarra.progAct - cantidad;
    }
}
