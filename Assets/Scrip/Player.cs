using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed=6;
    [SerializeField] private Transform San;
    private Animator anim;
    private enum MovementState{idle,walk,jumb,fall}
    [SerializeField] private LayerMask ground;
    float InputHorizontal;
    [SerializeField] private GameObject panle,textLose;
    private bool isGround,jumbx2;
    public AudioSource sjumb,sdeath;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        InputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(InputHorizontal*speed, rb.velocity.y);
        AmimStase();
        jumb();
    }

    public void AmimStase(){
        MovementState stase;
        if(InputHorizontal>0){
            transform.localScale = new Vector3(1,1,1);
             stase = MovementState.walk;
        }else if(InputHorizontal<0){
            transform.localScale = new Vector3(-1,1,1);
            stase = MovementState.walk;
        }else{
            stase = MovementState.idle;
        }

        if(rb.velocity.y>0.1){
            stase = MovementState.jumb;
        }else if(rb.velocity.y<-0.1){
            stase = MovementState.fall;
        }
        
        anim.SetInteger("Stase",(int)stase);
    }
    
    public void jumb(){
        bool isJumb= Physics2D.OverlapCircle(San.transform.position,0.2f,ground);
        if(Input.GetKeyDown(KeyCode.Space)){
            sjumb.Play();
            if(isJumb || jumbx2){
                rb.AddForce(Vector2.up*10,ForceMode2D.Impulse);
                jumbx2 = !jumbx2;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
           if(other.gameObject.CompareTag("saw")
           ||other.gameObject.CompareTag("spike")
           ||other.gameObject.CompareTag("trai")
           ||other.gameObject.CompareTag("phai")){
            anim.SetTrigger("death");
            rb.bodyType = RigidbodyType2D.Static;
            sdeath.Play();
            Invoke("Panle1",0.5f);
        }
        if(other.gameObject.CompareTag("tren")){
            var name = other.attachedRigidbody.name;
            Destroy(GameObject.Find(name));
        }
    }


  
    public void Panle1(){
        panle.SetActive(true);
        textLose.SetActive(true);
    }
}
