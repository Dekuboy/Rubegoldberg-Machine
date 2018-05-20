using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserQuit : MonoBehaviour {
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
