using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScaneManager : MonoBehaviour
{
   void Start()
    {

    }
    public void bolum_ac(string bolum_ismi)
   {
       SceneManager.LoadScene(bolum_ismi);
   }
    public void geri_buton(string geri)
    {
        SceneManager.LoadScene(geri);
    }
}
