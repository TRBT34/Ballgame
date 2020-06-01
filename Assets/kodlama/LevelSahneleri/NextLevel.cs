using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public string sonrakilevel;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "oyuncu")
        {
            PlayerPrefs.SetInt(sonrakilevel, 1);
            SceneManager.LoadScene("LevelKilit");
        }
    }
}
