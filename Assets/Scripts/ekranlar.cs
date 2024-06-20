using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ekranlar : MonoBehaviour
{
   
   public void oyunekran1()
    {
        
         SceneManager.LoadScene(2);
    }
    public void oyunekran2()
    {
        
         SceneManager.LoadScene(3);
    }
         public void menuekran() {
    
        
         SceneManager.LoadScene(1);
    }
    public void cikis()
    {
        
         Application.Quit();
    }
  
}