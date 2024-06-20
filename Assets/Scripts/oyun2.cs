using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class harfkontrol2 : MonoBehaviour
{ 

 public string aranankelime;

 public char[] arr_aranankelime;

 public TMP_Text tx_ekrandakikelime;

 public char[] arr_ekrandakikelime;

 public TMP_Text tx_ekrandakialtin;

 public TMP_Text tx_ekrandakialtinmarket;

 bool kelimebulundumu = false;

 bool kelimebelirlendimi = false;

 public int kacinciharf;

 public int dogrusayisi;



  public GameObject newButton;
 
  public Image kostum1gorsel1;
  public Image kostum1gorsel2;  
  public Image kostum1gorsel3;
  public Image kostum1gorsel4;


  public Image kostum2gorsel1;
  public Image kostum2gorsel2;  
  public Image kostum2gorsel3;
  public Image kostum2gorsel4;


  public Image kostum3gorsel1;
  public Image kostum3gorsel2;  
  public Image kostum3gorsel3;
  public Image kostum3gorsel4;


  public Image kostum4gorsel1;
  public Image kostum4gorsel2;  
  public Image kostum4gorsel3;
  public Image kostum4gorsel4;


  public Image kostum5gorsel1;
  public Image kostum5gorsel2;  
  public Image kostum5gorsel3;
  public Image kostum5gorsel4;


  public Image kostum6gorsel1;
  public Image kostum6gorsel2;  
  public Image kostum6gorsel3;
  public Image kostum6gorsel4;


  public bool kostum1varmi = false;
  public bool kostum2varmi = false;
  public bool kostum3varmi = false;
  public bool kostum4varmi = false;
  public bool kostum5varmi = false;
  public bool kostum6varmi = false;

  public bool kostum1secilimi = false;
  public bool kostum2secilimi = false;
  public bool kostum3secilimi = false;
  public bool kostum4secilimi = false;
  public bool kostum5secilimi = false;
  public bool kostum6secilimi = false;
  public bool kostumsuzmu = false;


  public Image gorsel1;  
  public Image gorsel2;
  public Image gorsel3;
  public Image gorsel4;

  public int altinsayisi;
  
  public int kalanhak;

  public int randomsayi;



  public void ipucu() {
 
  altinsayisi -= 10;
  PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
  tx_ekrandakialtin.text = altinsayisi.ToString();
    tx_ekrandakialtinmarket.text = altinsayisi.ToString();


  for(int i = 0; i < 50;i++){
   randomsayi = UnityEngine.Random.Range(0,arr_ekrandakikelime.Length);
   if(arr_ekrandakikelime[randomsayi] == '_' ){
    arr_ekrandakikelime[randomsayi] = arr_aranankelime[randomsayi];
    ekrandakikelimeyiyenile();
    kelimebittimi();
    break;
    }

  }

  }
  
    void Start()
    {
      aranankelime = "____________";
      arr_ekrandakikelime = aranankelime.ToCharArray();
      arr_aranankelime = aranankelime.ToCharArray();
      tx_ekrandakikelime.text = aranankelime;
      kalanhak = 4;
      altinsayisi = PlayerPrefs.GetInt(nameof(altinsayisi));
       tx_ekrandakialtin.text = altinsayisi.ToString();
        tx_ekrandakialtinmarket.text = altinsayisi.ToString();
      kostum1varmi = (PlayerPrefs.GetInt("kostum1varmi") != 0);
      kostum2varmi = (PlayerPrefs.GetInt("kostum2varmi") != 0);
      kostum3varmi = (PlayerPrefs.GetInt("kostum3varmi") != 0);
      kostum4varmi = (PlayerPrefs.GetInt("kostum4varmi") != 0);
      kostum5varmi = (PlayerPrefs.GetInt("kostum5varmi") != 0);
      kostum6varmi = (PlayerPrefs.GetInt("kostum6varmi") != 0);
      kostum1secilimi = (PlayerPrefs.GetInt("kostum1secilimi") != 0);
      kostum2secilimi = (PlayerPrefs.GetInt("kostum2secilimi") != 0);
      kostum3secilimi = (PlayerPrefs.GetInt("kostum3secilimi") != 0);
      kostum4secilimi = (PlayerPrefs.GetInt("kostum4secilimi") != 0);
      kostum5secilimi = (PlayerPrefs.GetInt("kostum5secilimi") != 0);
      kostum6secilimi = (PlayerPrefs.GetInt("kostum6secilimi") != 0);
      kostumsuzmu = (PlayerPrefs.GetInt("kostumsuzmu") != 0);









        if ( !(kostum1secilimi || kostum2secilimi || kostum3secilimi || kostum4secilimi || kostum5secilimi || kostum6secilimi)){
       kostumsuzmu = true;   
              PlayerPrefs.SetInt("kostumsuzmu",(kostumsuzmu ? 1 : 0));
    
        }

    }
    
    void Update(){
















      if (kalanhak == 3) {
    if (kostumsuzmu) {
              gorsel1.gameObject.SetActive(true);
                  kostum1gorsel1.gameObject.SetActive(false);     
                  kostum2gorsel1.gameObject.SetActive(false);
                  kostum3gorsel1.gameObject.SetActive(false);
                  kostum4gorsel1.gameObject.SetActive(false);
                  kostum5gorsel1.gameObject.SetActive(false);
                  kostum6gorsel1.gameObject.SetActive(false);              
      }
      if(kostum1secilimi) {
              kostum1gorsel1.gameObject.SetActive(true);
                  gorsel1.gameObject.SetActive(false);                                   
                  kostum2gorsel1.gameObject.SetActive(false);
                  kostum3gorsel1.gameObject.SetActive(false);
                  kostum4gorsel1.gameObject.SetActive(false);
                  kostum5gorsel1.gameObject.SetActive(false);
                  kostum6gorsel1.gameObject.SetActive(false);              
      }
       if(kostum2secilimi) {
              kostum2gorsel1.gameObject.SetActive(true);
                  gorsel1.gameObject.SetActive(false);  
                  kostum1gorsel1.gameObject.SetActive(false);
                  kostum3gorsel1.gameObject.SetActive(false);
                  kostum4gorsel1.gameObject.SetActive(false);
                  kostum5gorsel1.gameObject.SetActive(false);
                  kostum6gorsel1.gameObject.SetActive(false);                
      }
      if(kostum3secilimi) {
              kostum3gorsel1.gameObject.SetActive(true);
                  gorsel1.gameObject.SetActive(false);  
                  kostum1gorsel1.gameObject.SetActive(false);
                  kostum2gorsel1.gameObject.SetActive(false);
                  kostum4gorsel1.gameObject.SetActive(false);
                  kostum5gorsel1.gameObject.SetActive(false);
                  kostum6gorsel1.gameObject.SetActive(false);              
      }
       if(kostum4secilimi) {
              kostum4gorsel1.gameObject.SetActive(true);
                  gorsel1.gameObject.SetActive(false);  
                  kostum1gorsel1.gameObject.SetActive(false);
                  kostum2gorsel1.gameObject.SetActive(false);
                  kostum3gorsel1.gameObject.SetActive(false);
                  kostum5gorsel1.gameObject.SetActive(false);
                  kostum6gorsel1.gameObject.SetActive(false);
                        }
      if(kostum5secilimi) {
              kostum5gorsel1.gameObject.SetActive(true);
                  gorsel1.gameObject.SetActive(false);  
                  kostum1gorsel1.gameObject.SetActive(false);
                  kostum2gorsel1.gameObject.SetActive(false);
                  kostum3gorsel1.gameObject.SetActive(false);
                  kostum4gorsel1.gameObject.SetActive(false);
                  kostum6gorsel1.gameObject.SetActive(false);
                        }
      if(kostum6secilimi) {
              kostum6gorsel1.gameObject.SetActive(true);
                  gorsel1.gameObject.SetActive(false);  
                  kostum1gorsel1.gameObject.SetActive(false);
                  kostum2gorsel1.gameObject.SetActive(false);
                  kostum3gorsel1.gameObject.SetActive(false);
                  kostum4gorsel1.gameObject.SetActive(false);
                  kostum5gorsel1.gameObject.SetActive(false);
                    }
      
      
      
      
      
      }

      if (kalanhak == 2) {
   if(kostumsuzmu) {
                  gorsel1.gameObject.SetActive(false);
                  gorsel2.gameObject.SetActive(true);
                  kostum1gorsel2.gameObject.SetActive(false);                                   
                  kostum2gorsel2.gameObject.SetActive(false);
                  kostum3gorsel2.gameObject.SetActive(false);
                  kostum4gorsel2.gameObject.SetActive(false);
                  kostum5gorsel2.gameObject.SetActive(false);
                  kostum6gorsel2.gameObject.SetActive(false);



      }
     if(kostum1secilimi) {
        kostum1gorsel1.gameObject.SetActive(false);
        kostum1gorsel2.gameObject.SetActive(true);
                  gorsel2.gameObject.SetActive(false);
                  kostum2gorsel2.gameObject.SetActive(false);
                  kostum3gorsel2.gameObject.SetActive(false);
                  kostum4gorsel2.gameObject.SetActive(false);
                  kostum5gorsel2.gameObject.SetActive(false);
                  kostum6gorsel2.gameObject.SetActive(false);
      }
       if(kostum2secilimi) {
                      kostum2gorsel1.gameObject.SetActive(false);
              kostum2gorsel2.gameObject.SetActive(true);
                  gorsel2.gameObject.SetActive(false);
                  kostum1gorsel2.gameObject.SetActive(false);                                   
                  kostum3gorsel2.gameObject.SetActive(false);
                  kostum4gorsel2.gameObject.SetActive(false);
                  kostum5gorsel2.gameObject.SetActive(false);
                  kostum6gorsel2.gameObject.SetActive(false);
      }
      if(kostum3secilimi) {
                      kostum3gorsel1.gameObject.SetActive(false);
              kostum3gorsel2.gameObject.SetActive(true);
                  gorsel2.gameObject.SetActive(false);
                  kostum1gorsel2.gameObject.SetActive(false);                                   
                  kostum2gorsel2.gameObject.SetActive(false);
                  kostum4gorsel2.gameObject.SetActive(false);
                  kostum5gorsel2.gameObject.SetActive(false);
                  kostum6gorsel2.gameObject.SetActive(false);
      }
      if(kostum4secilimi) {
                      kostum4gorsel1.gameObject.SetActive(false);

              kostum4gorsel2.gameObject.SetActive(true);
                  gorsel2.gameObject.SetActive(false);
                  kostum1gorsel2.gameObject.SetActive(false);                                   
                  kostum2gorsel2.gameObject.SetActive(false);
                  kostum3gorsel2.gameObject.SetActive(false);
                  kostum5gorsel2.gameObject.SetActive(false);
                  kostum6gorsel2.gameObject.SetActive(false);
      }
      if(kostum5secilimi) {
                      kostum5gorsel1.gameObject.SetActive(false);

              kostum5gorsel2.gameObject.SetActive(true);
                  gorsel2.gameObject.SetActive(false);
                  kostum1gorsel2.gameObject.SetActive(false);                                   
                  kostum2gorsel2.gameObject.SetActive(false);
                  kostum3gorsel2.gameObject.SetActive(false);
                  kostum4gorsel2.gameObject.SetActive(false);
                  kostum6gorsel2.gameObject.SetActive(false);
      }
      if(kostum6secilimi) {
                      kostum6gorsel1.gameObject.SetActive(false);
              kostum6gorsel2.gameObject.SetActive(true);
                  gorsel2.gameObject.SetActive(false);
                  kostum1gorsel2.gameObject.SetActive(false);                                   
                  kostum2gorsel2.gameObject.SetActive(false);
                  kostum3gorsel2.gameObject.SetActive(false);
                  kostum4gorsel2.gameObject.SetActive(false);
                  kostum5gorsel2.gameObject.SetActive(false);
      }





      }
      if (kalanhak == 1) {
        if(kostumsuzmu) {
                        gorsel2.gameObject.SetActive(false);

              gorsel3.gameObject.SetActive(true);
                  kostum1gorsel3.gameObject.SetActive(false);                                   
                  kostum2gorsel3.gameObject.SetActive(false);
                  kostum3gorsel3.gameObject.SetActive(false);
                  kostum4gorsel3.gameObject.SetActive(false);
                  kostum5gorsel3.gameObject.SetActive(false);
                  kostum6gorsel3.gameObject.SetActive(false);
      }
     if(kostum1secilimi) {
      kostum1gorsel2.gameObject.SetActive(false);
              kostum1gorsel3.gameObject.SetActive(true);
                  gorsel3.gameObject.SetActive(false);
                  kostum2gorsel3.gameObject.SetActive(false);
                  kostum3gorsel3.gameObject.SetActive(false);
                  kostum4gorsel3.gameObject.SetActive(false);
                  kostum5gorsel3.gameObject.SetActive(false);
                  kostum6gorsel3.gameObject.SetActive(false);      }
       if(kostum2secilimi) {
                      kostum2gorsel2.gameObject.SetActive(false);

              kostum2gorsel3.gameObject.SetActive(true);
                  gorsel3.gameObject.SetActive(false);
                  kostum1gorsel3.gameObject.SetActive(false);                                   
                  kostum3gorsel3.gameObject.SetActive(false);
                  kostum4gorsel3.gameObject.SetActive(false);
                  kostum5gorsel3.gameObject.SetActive(false);
                  kostum6gorsel3.gameObject.SetActive(false);      }
      if(kostum3secilimi) {
                      kostum3gorsel2.gameObject.SetActive(false);
              kostum3gorsel3.gameObject.SetActive(true);
                  gorsel3.gameObject.SetActive(false);
                  kostum1gorsel3.gameObject.SetActive(false);                                   
                  kostum2gorsel3.gameObject.SetActive(false);
                  kostum4gorsel3.gameObject.SetActive(false);
                  kostum5gorsel3.gameObject.SetActive(false);
                  kostum6gorsel3.gameObject.SetActive(false);      }
      if(kostum4secilimi) {
                      kostum4gorsel2.gameObject.SetActive(false);

              kostum4gorsel3.gameObject.SetActive(true);
                  gorsel3.gameObject.SetActive(false);
                  kostum1gorsel3.gameObject.SetActive(false);                                   
                  kostum2gorsel3.gameObject.SetActive(false);
                  kostum3gorsel3.gameObject.SetActive(false);
                  kostum5gorsel3.gameObject.SetActive(false);
                  kostum6gorsel3.gameObject.SetActive(false);      }
      if(kostum5secilimi) {
                      kostum5gorsel2.gameObject.SetActive(false);
              kostum5gorsel3.gameObject.SetActive(true);
                  gorsel3.gameObject.SetActive(false);
                  kostum1gorsel3.gameObject.SetActive(false);                                   
                  kostum2gorsel3.gameObject.SetActive(false);
                  kostum3gorsel3.gameObject.SetActive(false);
                  kostum4gorsel3.gameObject.SetActive(false);
                  kostum6gorsel3.gameObject.SetActive(false);      }
      if(kostum6secilimi) {
                      kostum6gorsel2.gameObject.SetActive(false);
              kostum6gorsel3.gameObject.SetActive(true);
                   gorsel3.gameObject.SetActive(false);
                  kostum1gorsel3.gameObject.SetActive(false);                                   
                  kostum2gorsel3.gameObject.SetActive(false);
                  kostum3gorsel3.gameObject.SetActive(false);
                  kostum4gorsel3.gameObject.SetActive(false);
                  kostum5gorsel3.gameObject.SetActive(false);
                      }
      }
      if (kalanhak == 0) {
       if(kostumsuzmu) {         
             gorsel3.gameObject.SetActive(false);
              gorsel4.gameObject.SetActive(true);
                  kostum1gorsel4.gameObject.SetActive(false);                                   
                  kostum2gorsel4.gameObject.SetActive(false);
                  kostum3gorsel4.gameObject.SetActive(false);
                  kostum4gorsel4.gameObject.SetActive(false);
                  kostum5gorsel4.gameObject.SetActive(false);
                  kostum6gorsel4.gameObject.SetActive(false);      }
     if(kostum1secilimi) {
      kostum1gorsel3.gameObject.SetActive(false);
              kostum1gorsel4.gameObject.SetActive(true);
                  gorsel4.gameObject.SetActive(false);
                  kostum2gorsel4.gameObject.SetActive(false);
                  kostum3gorsel4.gameObject.SetActive(false);
                  kostum4gorsel4.gameObject.SetActive(false);
                  kostum5gorsel4.gameObject.SetActive(false);
                  kostum6gorsel4.gameObject.SetActive(false);      }
       if(kostum2secilimi) {
                      kostum2gorsel3.gameObject.SetActive(false);
              kostum2gorsel4.gameObject.SetActive(true);
                  gorsel4.gameObject.SetActive(false);
                  kostum1gorsel4.gameObject.SetActive(false);                                   
                  kostum3gorsel4.gameObject.SetActive(false);
                  kostum4gorsel4.gameObject.SetActive(false);
                  kostum5gorsel4.gameObject.SetActive(false);
                  kostum6gorsel4.gameObject.SetActive(false);      }
      if(kostum3secilimi) {
                      kostum3gorsel3.gameObject.SetActive(false);
              kostum3gorsel4.gameObject.SetActive(true);
                  gorsel4.gameObject.SetActive(false);
                  kostum1gorsel4.gameObject.SetActive(false);                                   
                  kostum2gorsel4.gameObject.SetActive(false);
                  kostum4gorsel4.gameObject.SetActive(false);
                  kostum5gorsel4.gameObject.SetActive(false);
                  kostum6gorsel4.gameObject.SetActive(false);      }
      if(kostum4secilimi) {
                      kostum4gorsel3.gameObject.SetActive(false);
              kostum4gorsel4.gameObject.SetActive(true);
                  gorsel4.gameObject.SetActive(false);
                  kostum1gorsel4.gameObject.SetActive(false);                                   
                  kostum2gorsel4.gameObject.SetActive(false);
                  kostum3gorsel4.gameObject.SetActive(false);
                  kostum5gorsel4.gameObject.SetActive(false);
                  kostum6gorsel4.gameObject.SetActive(false);      }
      if(kostum5secilimi) {
                      kostum5gorsel3.gameObject.SetActive(false);
              kostum5gorsel4.gameObject.SetActive(true);
                  gorsel4.gameObject.SetActive(false);
                  kostum1gorsel4.gameObject.SetActive(false);                                   
                  kostum2gorsel4.gameObject.SetActive(false);
                  kostum3gorsel4.gameObject.SetActive(false);
                  kostum4gorsel4.gameObject.SetActive(false);
                  kostum6gorsel4.gameObject.SetActive(false);      }
      if(kostum6secilimi) {
                      kostum6gorsel3.gameObject.SetActive(false);
              kostum6gorsel4.gameObject.SetActive(true);
                  gorsel4.gameObject.SetActive(false);
                  kostum1gorsel4.gameObject.SetActive(false);                                   
                  kostum2gorsel4.gameObject.SetActive(false);
                  kostum3gorsel4.gameObject.SetActive(false);
                  kostum4gorsel4.gameObject.SetActive(false);
                  kostum5gorsel4.gameObject.SetActive(false);
                      }
      }
    }
    public void yenidenbaslat(){
      
         SceneManager.LoadScene(1);
          System.Threading.Thread.Sleep(50);
      SceneManager.LoadScene(3);
    }

    public void kostum1satinal(){
     if(!kostum1varmi) {
      if(altinsayisi > 100 ) {
        altinsayisi-= 100;
        PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
        tx_ekrandakialtin.text = altinsayisi.ToString();
        tx_ekrandakialtinmarket.text = altinsayisi.ToString();
        kostum1varmi = true;
      PlayerPrefs.SetInt("kostum1varmi",(kostum1varmi ? 1 : 0));

      }
     }else {
        kostum1secilimi = true;
               PlayerPrefs.SetInt("kostum1secilimi",(kostum1secilimi ? 1 : 0));
        kostum2secilimi = false;
               PlayerPrefs.SetInt("kostum2secilimi",(kostum2secilimi ? 1 : 0));
        kostum3secilimi = false;
               PlayerPrefs.SetInt("kostum3secilimi",(kostum3secilimi ? 1 : 0));
        kostum4secilimi = false;
               PlayerPrefs.SetInt("kostum4secilimi",(kostum4secilimi ? 1 : 0));
        kostum5secilimi = false;
               PlayerPrefs.SetInt("kostum5secilimi",(kostum5secilimi ? 1 : 0));
        kostum6secilimi = false;
               PlayerPrefs.SetInt("kostum6secilimi",(kostum6secilimi ? 1 : 0));
        kostumsuzmu = false;
       PlayerPrefs.SetInt("kostumsuzmu",(kostumsuzmu ? 1 : 0));


      }


    }

    public void kostum2satinal(){
     if(!kostum2varmi) {
      if(altinsayisi > 200 ) {
        altinsayisi-= 200;
        PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
        tx_ekrandakialtin.text = altinsayisi.ToString();
        tx_ekrandakialtinmarket.text = altinsayisi.ToString();
        kostum2varmi = true;
      PlayerPrefs.SetInt("kostum2varmi",(kostum2varmi ? 1 : 0));

      }
     }else {
        kostum1secilimi = false;
               PlayerPrefs.SetInt("kostum1secilimi",(kostum1secilimi ? 1 : 0));
        kostum2secilimi = true;
               PlayerPrefs.SetInt("kostum2secilimi",(kostum2secilimi ? 1 : 0));
        kostum3secilimi = false;
               PlayerPrefs.SetInt("kostum3secilimi",(kostum3secilimi ? 1 : 0));
        kostum4secilimi = false;
               PlayerPrefs.SetInt("kostum4secilimi",(kostum4secilimi ? 1 : 0));
        kostum5secilimi = false;
               PlayerPrefs.SetInt("kostum5secilimi",(kostum5secilimi ? 1 : 0));
        kostum6secilimi = false;
               PlayerPrefs.SetInt("kostum6secilimi",(kostum6secilimi ? 1 : 0));
        kostumsuzmu = false;
       PlayerPrefs.SetInt("kostumsuzmu",(kostumsuzmu ? 1 : 0));


      }


    }
public void kostum3satinal(){
     if(!kostum3varmi) {
      if(altinsayisi > 300 ) {
        altinsayisi-= 300;
        PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
        tx_ekrandakialtin.text = altinsayisi.ToString();
        tx_ekrandakialtinmarket.text = altinsayisi.ToString();
        kostum3varmi = true;
      PlayerPrefs.SetInt("kostum3varmi",(kostum3varmi ? 1 : 0));

      }
     }else {
        kostum1secilimi = false;
               PlayerPrefs.SetInt("kostum1secilimi",(kostum1secilimi ? 1 : 0));
        kostum2secilimi = false;
               PlayerPrefs.SetInt("kostum2secilimi",(kostum2secilimi ? 1 : 0));
        kostum3secilimi = true;
               PlayerPrefs.SetInt("kostum3secilimi",(kostum3secilimi ? 1 : 0));
        kostum4secilimi = false;
               PlayerPrefs.SetInt("kostum4secilimi",(kostum4secilimi ? 1 : 0));
        kostum5secilimi = false;
               PlayerPrefs.SetInt("kostum5secilimi",(kostum5secilimi ? 1 : 0));
        kostum6secilimi = false;
               PlayerPrefs.SetInt("kostum6secilimi",(kostum6secilimi ? 1 : 0));
        kostumsuzmu = false;
       PlayerPrefs.SetInt("kostumsuzmu",(kostumsuzmu ? 1 : 0));


      }
    }
    public void kostum4satinal(){
     if(!kostum4varmi) {
      if(altinsayisi > 400 ) {
        altinsayisi-= 400;
        PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
        tx_ekrandakialtin.text = altinsayisi.ToString();
        tx_ekrandakialtinmarket.text = altinsayisi.ToString();
        kostum4varmi = true;
      PlayerPrefs.SetInt("kostum4varmi",(kostum4varmi ? 1 : 0));

      }
     }else {
        kostum1secilimi = false;
               PlayerPrefs.SetInt("kostum1secilimi",(kostum1secilimi ? 1 : 0));
        kostum2secilimi = false;
               PlayerPrefs.SetInt("kostum2secilimi",(kostum2secilimi ? 1 : 0));
        kostum3secilimi = false;
               PlayerPrefs.SetInt("kostum3secilimi",(kostum3secilimi ? 1 : 0));
        kostum4secilimi = true;
               PlayerPrefs.SetInt("kostum4secilimi",(kostum4secilimi ? 1 : 0));
        kostum5secilimi = false;
               PlayerPrefs.SetInt("kostum5secilimi",(kostum5secilimi ? 1 : 0));
        kostum6secilimi = false;
               PlayerPrefs.SetInt("kostum6secilimi",(kostum6secilimi ? 1 : 0));
        kostumsuzmu = false;
       PlayerPrefs.SetInt("kostumsuzmu",(kostumsuzmu ? 1 : 0));


      }


    }
public void kostum5satinal(){
     if(!kostum5varmi) {
      if(altinsayisi > 500 ) {
        altinsayisi-= 500;
        PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
        tx_ekrandakialtin.text = altinsayisi.ToString();
        tx_ekrandakialtinmarket.text = altinsayisi.ToString();
        kostum5varmi = true;
      PlayerPrefs.SetInt("kostum5varmi",(kostum5varmi ? 1 : 0));

      }
     }else {
        kostum1secilimi = false;
               PlayerPrefs.SetInt("kostum1secilimi",(kostum1secilimi ? 1 : 0));
        kostum2secilimi = false;
               PlayerPrefs.SetInt("kostum2secilimi",(kostum2secilimi ? 1 : 0));
        kostum3secilimi = false;
               PlayerPrefs.SetInt("kostum3secilimi",(kostum3secilimi ? 1 : 0));
        kostum4secilimi = false;
               PlayerPrefs.SetInt("kostum4secilimi",(kostum4secilimi ? 1 : 0));
        kostum5secilimi = true;
               PlayerPrefs.SetInt("kostum5secilimi",(kostum5secilimi ? 1 : 0));
        kostum6secilimi = false;
               PlayerPrefs.SetInt("kostum6secilimi",(kostum6secilimi ? 1 : 0));
        kostumsuzmu = false;
       PlayerPrefs.SetInt("kostumsuzmu",(kostumsuzmu ? 1 : 0));


      }


    }
public void kostum6satinal(){
     if(!kostum6varmi) {
      if(altinsayisi > 600 ) {
        altinsayisi-= 600;
        PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
        tx_ekrandakialtin.text = altinsayisi.ToString();
        tx_ekrandakialtinmarket.text = altinsayisi.ToString();
        kostum6varmi = true;
      PlayerPrefs.SetInt("kostum6varmi",(kostum6varmi ? 1 : 0));

      }
     }else {
        kostum1secilimi = false;
               PlayerPrefs.SetInt("kostum1secilimi",(kostum1secilimi ? 1 : 0));
        kostum2secilimi = false;
               PlayerPrefs.SetInt("kostum2secilimi",(kostum2secilimi ? 1 : 0));
        kostum3secilimi = false;
               PlayerPrefs.SetInt("kostum3secilimi",(kostum3secilimi ? 1 : 0));
        kostum4secilimi = false;
               PlayerPrefs.SetInt("kostum4secilimi",(kostum4secilimi ? 1 : 0));
        kostum5secilimi = false;
               PlayerPrefs.SetInt("kostum5secilimi",(kostum5secilimi ? 1 : 0));
        kostum6secilimi = true;
               PlayerPrefs.SetInt("kostum6secilimi",(kostum6secilimi ? 1 : 0));
        kostumsuzmu = false;
       PlayerPrefs.SetInt("kostumsuzmu",(kostumsuzmu ? 1 : 0));


      }


    }


    public void abutton(){
        char girilenharf = 'A';
        if(kelimebelirlendimi){
       if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    } 
    else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

  public void çbutton(){
     char girilenharf = 'Ç';
    if(kelimebelirlendimi){
     if(kalanhak > 0) {
    
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }
    else {
        kalanhak -= 1;
      }
}
}}
else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

  public void ğbutton(){
    char girilenharf = 'Ğ';
    if(kelimebelirlendimi){
     if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
 if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}
else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

public void bbutton(){
    char girilenharf = 'B';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}
else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void cbutton(){
     char girilenharf = 'C';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}
else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void dbutton(){
     char girilenharf = 'D';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
    
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
 if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}
else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void ebutton(){
    char girilenharf = 'E';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
 if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void fbutton(){
    char girilenharf = 'F';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
 if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void gbutton(){
    char girilenharf = 'G';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
        }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}
public void hbutton(){
     char girilenharf = 'H';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void ıbutton(){
     char girilenharf = 'I';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
   if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void ibutton(){
     char girilenharf = 'İ';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void jbutton(){
    char girilenharf = 'J';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

public void kbutton(){
    char girilenharf = 'K';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void lbutton(){
    char girilenharf = 'L';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
 if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}



public void mbutton(){
     char girilenharf = 'M';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
  if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}



public void nbutton(){
    char girilenharf = 'N';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
 if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void obutton(){
    char girilenharf = 'O';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
   if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void öbutton(){
     char girilenharf = 'Ö';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
    if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}



public void pbutton(){
     char girilenharf = 'P';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
   if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}


public void rbutton(){
      char girilenharf = 'R';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
 if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

public void sbutton(){
     char girilenharf = 'S';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
    if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

public void şbutton(){
    char girilenharf = 'Ş';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
    if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

public void tbutton(){
    char girilenharf = 'T';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
   if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

public void ubutton(){
     char girilenharf = 'U';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
   if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}
public void übutton(){
        char girilenharf = 'Ü';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
   if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}
}
public void vbutton(){
     char girilenharf = 'V';
    if(kelimebelirlendimi){
   if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
    if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}

public void ybutton(){
    char girilenharf = 'Y';
    if(kelimebelirlendimi){
      if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
    if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}
}
public void zbutton(){ 
     char girilenharf = 'Z';
    if(kelimebelirlendimi){
     if(kalanhak > 0) {
     bool harfbulundumu = false;
     for (int i = 0; i < arr_aranankelime.Length;i++) {
      if (arr_aranankelime[i] == girilenharf) {
        arr_ekrandakikelime[i] = girilenharf;
         harfbulundumu = true;
      }
    }
    if(!kelimebulundumu){
    if (harfbulundumu) {
      ekrandakikelimeyiyenile();
      kelimebittimi();
    }else {
        kalanhak -= 1;
      }
}
}
}else {
   arr_aranankelime[kacinciharf] = girilenharf;
    arr_ekrandakikelime[kacinciharf] =girilenharf;
   kacinciharf+= 1;
   ekrandakikelimeyiyenile();
}}



public void kelimeyibelirle(){
  if(!kelimebelirlendimi){
    kelimebelirlendimi = true;
    tx_ekrandakikelime.text = "";

    for (int i = 0; i < arr_aranankelime.Length;i++){

        if(!(arr_aranankelime[i] == '_')){
            tx_ekrandakikelime.text += "_";
    }}
    

      arr_ekrandakikelime = tx_ekrandakikelime.text.ToCharArray();
}}














void kelimebittimi(){
  
 for (int i = 0; i < arr_ekrandakikelime.Length;i++){
   if(arr_aranankelime[i] == arr_ekrandakikelime[i]) {
    dogrusayisi++;
   }

 }
 if (dogrusayisi == arr_ekrandakikelime.Length) {
    kelimebulundumu = true;
     altinsayisi += 10;
   PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
  tx_ekrandakialtin.text = altinsayisi.ToString();
  tx_ekrandakialtinmarket.text = altinsayisi.ToString();
 }else {
 dogrusayisi = 0;
}}






 void ekrandakikelimeyiyenile() {

  string duzenleyici = "";

  for (int i = 0; i < arr_ekrandakikelime.Length;i++) {
   duzenleyici += arr_ekrandakikelime[i];
  }
  tx_ekrandakikelime.text = duzenleyici;
 }


}
