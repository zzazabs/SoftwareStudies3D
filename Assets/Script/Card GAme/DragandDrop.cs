using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;

    public enum Slot { WEAPON, HEAD, CHEST, LEGS, INVENTORY};
    public Slot typeofitem = Slot.WEAPON;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("On Begin Drag");
 
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false; 
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("On Begin Drag");

        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("On Begin Drag");

        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }

}
