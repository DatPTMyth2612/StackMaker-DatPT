using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{   
    public int Level;

    public void OpenScene()
    {
        SceneManager.LoadScene("Lv " + Level.ToString());
    }
}
