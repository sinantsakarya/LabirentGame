using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainmanu : MonoBehaviour
{
    public GameObject muteButton;
    public GameObject activeButton;
    public GameObject settingmenu;
    [SerializeField] AudioClip clickSound;
    [SerializeField] AudioSource sourceSound;

    public void playGame()
    {
        SceneManager.LoadScene(0);
        ClickSoundMethod();
    }
    public void mainMenu()
    {
        settingmenu.SetActive(false);
        ClickSoundMethod();
    }

    public void settingsMenu()
    {
        settingmenu.SetActive(true);
        ClickSoundMethod();
    }

    public void quitGame()
    {
        Application.Quit();
        ClickSoundMethod();
    }



    private void Awake()
    {
        sourceSound = gameObject.AddComponent<AudioSource>();
    }
    public void activesoundButton()
    {
        Debug.Log("ses açýldý");
        muteButton.SetActive(true);
        activeButton.SetActive(false);
        ClickSoundMethod();
        //ses açma
    }
    public void mutesoundButton()
    {
        Debug.Log("ses kapandý");
        activeButton.SetActive(true);
        muteButton.SetActive(false);
        ClickSoundMethod();
        //ses kapatma
    }
    public void ClickSoundMethod()
    {
        sourceSound.PlayOneShot(clickSound);
    }
}