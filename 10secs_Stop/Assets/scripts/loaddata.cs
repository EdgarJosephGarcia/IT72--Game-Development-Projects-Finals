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
       // PlayerPrefs.DeleteKey("username");
       SceneManager.LoadScene("username");
    }
    public void clickStart(){
       // PlayerPrefs.DeleteKey("username");
       SceneManager.LoadScene("SampleScene");
    }
}
