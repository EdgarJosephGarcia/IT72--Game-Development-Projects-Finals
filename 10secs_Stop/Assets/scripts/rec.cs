using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class rec : MonoBehaviour
{
    public Text Usertime;
    public Text Usernamebox;
    public Text winnerbox;
    public Text ann;
    // Start is called before the first frame update
    void Start()
    {
         Usertime.text = PlayerPrefs.GetString("time");
         Usernamebox.text = PlayerPrefs.GetString("username");

         if (Usertime.text == "10:00"){
            Debug.Log("winner");
            winnerbox.text = PlayerPrefs.GetString("username")+" 10:00";
            ann.text = "congratulations you WIN";
         }
        else {
             Debug.Log("lose");
            ann.text = "Sorry you lose";
         }
        }
    
         
    
public void clickcancel(){
        SceneManager.LoadScene("home");
    }
}
