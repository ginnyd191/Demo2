using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    private Animator anim;
    public GameObject panle,textWin;
    public AudioSource winer;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            anim.SetTrigger("winer");
            Invoke("Panle1",2f);
            winer.Play();
        }
    }
    public void Panle1(){
        panle.SetActive(true);
        textWin.SetActive(true);
    }
}
