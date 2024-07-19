using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void home(){
        SceneManager.LoadScene("MainMenu");
    }
    public void lv1(){
        SceneManager.LoadScene("lv1");
    }
    public void lv2(){
        SceneManager.LoadScene("lv2");
    }
    public void lv3(){
        SceneManager.LoadScene("lv3");
    }
    public void Replay(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Time.timeScale=1;

    }
}
