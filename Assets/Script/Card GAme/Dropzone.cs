using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Dropzone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    public DragandDrop.Slot typeofItem = DragandDrop.Slot.INVENTORY;

    public void OnPointerEnter(PointerEventData eventdata)
        {
        //Debug.Log("OnPointerEnter");
        }
    public void OnPointerExit(PointerEventData eventdata)
        {
        //Debug.Log("OnPointerExit");
        }
    public void OnDrop(PointerEventData eventdata)
        {
        Debug.Log(eventdata.pointerDrag.name + "was dropped on" + gameObject.name);

        DragandDrop d = eventdata.pointerDrag.GetComponent<DragandDrop>();
        if(d !=null)
            {
            if(typeofItem == d.typeofitem || typeofItem==DragandDrop.Slot.INVENTORY )
            d.parentToReturnTo = this.transform;
            }
        }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
