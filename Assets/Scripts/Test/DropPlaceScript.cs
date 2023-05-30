using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlaceScript : MonoBehaviour, IDropHandler
{
    public string ThePlaceFor;
    public bool CardCheck = false;

    public void OnDrop(PointerEventData eventData)
    {
        CardScript card = eventData.pointerDrag.GetComponent<CardScript>();
        if (card)
        {
            card.defaultParent = transform;
        }

        if (ThePlaceFor == eventData.pointerDrag.gameObject.name)
            CardCheck = true;
        else
            CardCheck = false;
    }
}
