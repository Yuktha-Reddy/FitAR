using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   
    public void airsquats(){
         SceneManager.LoadScene(1);
    }
    public void jumpingjacks(){
         SceneManager.LoadScene(2);
    }
    public void kettledown(){
         SceneManager.LoadScene(3);
    }
    public void kettleup(){
         SceneManager.LoadScene(4);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
