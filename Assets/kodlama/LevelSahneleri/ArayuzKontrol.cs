using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ArayuzKontrol : MonoBehaviour
{      
        public void basadon(string bolum_isim)
        {
            SceneManager.LoadScene(bolum_isim);
        }
        public void levelarayüz(string arayuz_isim)
        {
            SceneManager.LoadScene(arayuz_isim);
        }
}
