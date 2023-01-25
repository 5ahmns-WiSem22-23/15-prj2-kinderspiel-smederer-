using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    
    private bool isHeld = false;
    private bool dragged = false;


    void Update()
    {
        Vector2 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (isHeld == true && dragged == false)
        {
            this.gameObject.transform.localPosition = new Vector2(mousePos.x, mousePos.y);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) //linker Mausbutton
        {
           
            isHeld = true;
        }
    }
    private void OnMouseUp()
    {
       
        if(Eating.correctArea == true) //wenn beim Mund zertört es sich selbts 
        {
            Destroy(this.gameObject);
            Eating.correctArea =false;
            Eating.count++;
        }
        isHeld = false;
        dragged = true;
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f); ;
    }
  







}
