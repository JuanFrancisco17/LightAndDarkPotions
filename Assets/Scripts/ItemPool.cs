using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPool : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        DragHandler.itemDragging.transform.SetParent(transform);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
