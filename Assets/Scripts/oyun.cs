using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class harfkontrol : MonoBehaviour
{ 
  public string[] isimler = new string[] {"ELMA", "MASA", "KEDİ", "RADYO", "AĞAÇ", "KITAP", "KALEM", "DENİZ", "BİLGİ", "KARDEŞ", "EVREN", "BİSİKLET", "OYUN", "SES", "ÖRDEK", "GÖZLÜK", "GÖKYÜZÜ", "BIÇAK", "YEMEK", "SEBZE", "MEYVE", "KUŞ", "RÜYA", "GÜNEŞ", "BULUT", "ŞEHİR", "KÖPEK", "RENK", "RESİM", "FİLM", "DERS", "HAVA", "HASTA", "DOKTOR", "YAZI", "MASA", "AYAK", "KAPI", "KRAL", "MASA", "YATAK", "GECE", "GÜN", "YIL", "TARİH", "DİL", "ŞEHİR", "ORMAN", "KIRLANGIÇ", "MEKTUP", "SEVGİ", "SAYI", "KÖY", "YUVA", "KURT", "FARE", "GELİNCİK", "ÇİÇEK", "PARA", "TÜY", "DALGA", "KÖPRÜ", "ÇANTA", "AYAKKABI", "ÇORAP", "ÇAMAŞIR", "KUMAŞ", "YORGAN", "BAŞLIK", "PANO", "TOP", "VAZO", "AYNA", "PERİ", "ÖRDEK", "DAL", "TANE", "YÜZ", "MASA", "SANDALYE", "TAHTA", "TAŞ", "CÜZDAN", "YÜZÜK", "GEMİ", "BALIK", "SANDIK", "KUM", "KULE", "UÇAK", "UZAY", "RÜZGAR", "KORKU", "HÜZÜN", "ÇOCUK", "OKUL", "ANAOKULU", "KÜTÜPHANE", "HASTANE", "SAAT", "GÖZLÜK", "TANE", "KARPUZ", "RADYO", "ÇOCUK", "ŞEKER", "RÜYA", "MUM", "ÇAY", "KAHVE", "EVREN", "KABLO", "KUTU", "MASA", "ŞARKI", "OYUN", "GECE", "GÜN", "KIŞ", "YAZ" };

 public string aranankelime;

 public char[] arr_aranankelime;

 public TMP_Text tx_ekrandakikelime;

 public char[] arr_ekrandakikelime;

  public TMP_Text tx_ekrandakialtin;

    public TMP_Text tx_ekrandakialtinmarket;

  
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

  bool kelimebulundumu = false;


  public void ipucu() {
 
  altinsayisi -= 10;
  PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
  tx_ekrandakialtin.text = altinsayisi.ToString();
    tx_ekrandakialtinmarket.text = altinsayisi.ToString();


  for(int i = 0; i < 50;i++){
   randomsayi = UnityEngine.Random.Range(0,arr_aranankelime.Length);
   if(arr_ekrandakikelime[randomsayi] == '_' ){
    arr_ekrandakikelime[randomsayi] = arr_aranankelime[randomsayi];
    ekrandakikelimeyiyenile();
    kelimebittimi();
    break;
    }

  }
 



  }
  void aradigimizkelime() {
    aranankelime = isimler[UnityEngine.Random.Range(0,isimler.Length)];

    arr_aranankelime = aranankelime.ToCharArray();
    tx_ekrandakikelime.text = "";

    for (int i = 0; i < aranankelime.Length;i++){

        tx_ekrandakikelime.text += "_";
    }

      arr_ekrandakikelime = tx_ekrandakikelime.text.ToCharArray();


  }
    // Start is called before the first frame update
    void Start()
    {
     aradigimizkelime();
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
      SceneManager.LoadScene(2);
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
       if(kalanhak > 0) {
     char girilenharf = 'A';
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

  public void çbutton(){
     if(kalanhak > 0) {
     char girilenharf = 'Ç';
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

  public void ğbutton(){
     if(kalanhak > 0) {
     char girilenharf = 'Ğ';
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

public void bbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'B';
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


public void cbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'C';
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


public void dbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'D';
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


public void ebutton(){
   if(kalanhak > 0) {
     char girilenharf = 'E';
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


public void fbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'F';
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


public void gbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'G';
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
}
public void hbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'H';
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


public void ıbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'I';
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


public void ibutton(){
   if(kalanhak > 0) {
     char girilenharf = 'İ';
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


public void jbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'J';
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
}

public void kbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'K';
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


public void lbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'L';
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



public void mbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'M';
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



public void nbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'N';
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
}


public void obutton(){
   if(kalanhak > 0) {
     char girilenharf = 'O';
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


public void öbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'Ö';
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



public void pbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'P';
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
}


public void rbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'R';
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

public void sbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'S';
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
}

public void şbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'Ş';
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
}

public void tbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'T';
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
}

public void ubutton(){
   if(kalanhak > 0) {
     char girilenharf = 'U';
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
}
public void übutton(){
   if(kalanhak > 0) {
     char girilenharf = 'Ü';
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
}

public void vbutton(){
   if(kalanhak > 0) {
     char girilenharf = 'V';
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
}

public void ybutton(){
      if(kalanhak > 0) {
     char girilenharf = 'Y';
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
}
public void zbutton(){ 
     if(kalanhak > 0) {
     char girilenharf = 'Z';
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
}

















void kelimebittimi(){

 if (aranankelime == tx_ekrandakikelime.text) {
   
   altinsayisi += 10;
   PlayerPrefs.SetInt(nameof(altinsayisi),altinsayisi);
  tx_ekrandakialtin.text = altinsayisi.ToString();
  tx_ekrandakialtinmarket.text = altinsayisi.ToString();

  kelimebulundumu = true;
}
}






 void ekrandakikelimeyiyenile() {

  string duzenleyici = "";

  for (int i = 0; i < arr_ekrandakikelime.Length;i++) {
   duzenleyici += arr_ekrandakikelime[i];
  }
  tx_ekrandakikelime.text = duzenleyici;
 }


}
