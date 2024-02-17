using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// import terlebih dahulu Scene Management
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Buatlah sebuah function dengan nama apa saja
    public void playGame(){
        // Menampilkan scene Flappy Bird
        SceneManager.LoadScene(1);
    }

    // Function quit game untuk keluar dari aplikasi
    public void quitGame(){
        Application.Quit();
    }
}
