using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        //transform.position = eventData.position;
        transform.localPosition += new Vector3(eventData.delta.x, eventData.delta.y, 0) / transform.lossyScale.x;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
}
