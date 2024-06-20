using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class renkdegis : MonoBehaviour

  
{
    public GameObject newButton;
   public void renkdegistir(){
   
    newButton.GetComponent<Button>().interactable = false;
   }
   public void belirlendim(){
        newButton.GetComponent<Button>().interactable = false;

   }
   
}
