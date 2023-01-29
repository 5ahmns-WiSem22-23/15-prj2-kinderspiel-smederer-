using UnityEngine.SceneManagement;
using UnityEngine;


public class DragDrop : MonoBehaviour
{
    
    private bool isHeld = false;
    private bool dragged = false;


    void Update()
    {
        Vector2 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (isHeld == true && (dragged == false || this.gameObject.tag == "dragAlways"))
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
            Score.count++;
            //
            //
            //
            if (this.gameObject.tag == "dragAlways")                    // dieses if statement nur für "bennenen"-scene 
            {
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
               
            }
            //
            //
            //
        }
        isHeld = false;
        dragged = true;
        Score.totalTrys++;
      
        
        if(this.gameObject.tag != "dragAlways")
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
            this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }
        
    }
  







}
