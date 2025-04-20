using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventdata)
    {
        Debug.LogWarning("DRAG STARTED");
    }
    public void OnDrag(PointerEventData eventdata)
    {
        this.transform.position = eventdata.position;

    }
    public void OnEndDrag(PointerEventData eventdata)
    {
        Debug.LogWarning("DRAG ENDED");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
