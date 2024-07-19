using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class die : MonoBehaviour
{
    // Start is called before the first frame update
    private int count;
    [SerializeField]private Text items,textPoint;
        public GameObject particleSystem1;
        public AudioSource coins;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("items")){
            Destroy(other.gameObject);
            count++;
            items.text = "Point: "+count;
            textPoint.text = "Point: "+count;
            Instantiate(particleSystem1,other.gameObject.transform.position,other.transform.localRotation);
            coins.Play();
        }
    }
}
