using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platF : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5;
     // Start is called before the first frame update
    public float left,right;
    private bool isRight; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        var platF = transform.position.x;
        if(platF <left){
            isRight = true;
        }
        else if(platF >right){
            isRight = false;
        }if(isRight==true){
            transform.Translate(new Vector3(Time.deltaTime*speed, 0,0));
            transform.localScale=new Vector3(1,1,1);
           
        }else{
            transform.Translate(new Vector3(-Time.deltaTime*speed, 0,0));
             transform.localScale=new Vector3(1,1,1);
        
        }
}
private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.name =="Player"){
        other.gameObject.transform.SetParent(transform);
    }
  }
   private void OnTriggerExit2D(Collider2D other) {
    if(other.gameObject.name =="Player"){
        other.gameObject.transform.SetParent(null);
    }
  }
}
