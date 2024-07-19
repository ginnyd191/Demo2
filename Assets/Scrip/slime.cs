using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class slime : MonoBehaviour
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
            transform.localScale=new Vector3((float)-0.6089, (float)0.5587,1);
           
        }else{
            transform.Translate(new Vector3(-Time.deltaTime*speed, 0,0));
             transform.localScale=new Vector3((float)0.6089, (float)0.5587,1);
        
        }
}

}
