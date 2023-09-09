using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggObjct : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("begin drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("end drag");
    }
}
