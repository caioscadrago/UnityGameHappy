using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
     public void OnRestart() 
    {
        SceneManager.LoadScene("Level 1");

        Player.vida=3;
    }
}
