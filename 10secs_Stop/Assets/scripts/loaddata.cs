using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loaddata : MonoBehaviour
{
   public Text Usernamebox;
    // Start is called before the first frame update
    void Start()
    {
        Usernamebox.text = PlayerPrefs.GetString("username");
    }

    public void clickusername(){
       SceneManager.LoadScene("username");
    }
    public void clickStart(){
       SceneManager.LoadScene("SampleScene");
    }
    public void clickexit(){
       Application.Quit();
    }
}
