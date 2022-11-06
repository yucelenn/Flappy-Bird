using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public int skor;
    public Text SkorText;
    public Text Best;
    public Text SkorunText;
    public Text s11;
    public GameObject skorTablo, panell;
    public int[] tablo = {0,0,0,0,0,0,0,0,0,0,0};
    string t = "";
    void Start()
    {
        if (PlayerPrefs.HasKey("geciciSkor"))  //geciciSkor varsa (oyun ilk defa oynanmiyorsa)
        {
            SkorText.text = skor.ToString();
            SkorunText.text = skor.ToString();
            for (int i = 1; i < tablo.Length; i++)   //playerprefleri doldurmak icin
            {
                string p = "";
                p = "p" + (i).ToString();     // pi ( p1, p2, .... p10 )

                if (!(PlayerPrefs.HasKey(p)))   // pi yoksa(p1, p2 ... p10) oluþtur ve geciciSkor u ata
                {
                    PlayerPrefs.SetInt(p, PlayerPrefs.GetInt("geciciSkor")); 
                    PlayerPrefs.Save();
                }                                                            
                else       // pi (p1 p2 ... p10) varsa p11 e geciciSkor u ata
                {
                        PlayerPrefs.SetInt("p11", PlayerPrefs.GetInt("geciciSkor"));
                        PlayerPrefs.Save();                    
                }
            }
            
            for (int i = 0; i <tablo.Length; i++)   //playerprefleri diziye al.
            {
                string p = "";
                p = "p" + (i+1).ToString();        // pi+1 ( p1, p2, .... p11 )
                tablo[i] = PlayerPrefs.GetInt(p);  // tablo0=p1, tablo1=p2, .... tablo10=p11
            }

            System.Array.Sort(tablo);   // diziyi kucukten buyuge sýralar. tablo0=enkucuk,......,tablo10=enbuyuk

            int[] dist = tablo.Distinct().ToArray();  //dizideki ayný elemanlari temizlemek icin

            for (int i = dist.Length; i > 0; i--)  // diziden playerpreflere ve string t ye al 
            {
                string p = "";
                p = "p" + (i).ToString();         // pi ( p11, p10, .... p1 )
                PlayerPrefs.SetInt(p, dist[dist.Length-i]);  // p11=dist0, p10=dist1, ..... p1=dist10
                PlayerPrefs.Save();
                t = t + dist[i - 1].ToString() + "\n";
            }          
            s11.text = t;  // skoru toplu halde bas.
            Best.text = dist[dist.Length-1].ToString();
        }
        else
        {
            SkorunText.text = skor.ToString();
            PlayerPrefs.SetInt("geciciSkor", 0); // geciciSkor verisi yoksa 0 atasin
            PlayerPrefs.SetInt("p1", PlayerPrefs.GetInt("geciciSkor"));
            SkorText.text = skor.ToString();
            s11.text = PlayerPrefs.GetInt("p1").ToString();
        }     
    }
    public void skorGuncelle()   //skoru guncelleyen metod
    {
        skor++;
        PlayerPrefs.SetInt("geciciSkor", skor); //lokal veritabanina kaydet skoru (geciciSkor=skor; gibi)
        SkorText.text=skor.ToString();     //oyun esnasinda ekrana yazilacak
        SkorunText.text = skor.ToString(); //oyunsonunda score alanina yazilacak
    }
    public void clear()  //clear tusu icin
    {
        panell.SetActive(true);
    }
    public void clearYes()  //clear yes tusu icin
    {
        PlayerPrefs.DeleteAll();
        s11.text = "0";
        panell.SetActive(false);
    }
    public void clearNo()  //clear no tusu icin
    {
        panell.SetActive(false);
    }
    public void play()   //baslatma tusu icin
    {
        SceneManager.LoadScene(1);  //SampleScene baslar
    }
    public void replay()   //retry tusu icin
    {
        SceneManager.LoadScene(1);  //SampleScene baslar
    }
    public void skorlar()   //scores tusu icin
    {
        skorTablo.SetActive(true); //basinca tablo acilsin. 
    }
    public void close()   //scores tablosu kapama tusu icin
    {
        skorTablo.SetActive(false); //basinca tablo kapansin
    }
    public void cikis() //cikis tusu icin
    {
        Application.Quit();
    }
}
