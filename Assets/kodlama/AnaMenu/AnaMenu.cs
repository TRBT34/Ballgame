using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    public string oyun;
    public string ayar;
    
   public void SahneGecisOyun()
    {
       SceneManager.LoadScene(oyun);
    }
   public void SahneGecisAyar()
   {
       SceneManager.LoadScene(oyun);
   }
   public void OyundanCik()
   {
       Application.Quit();
   }
}
