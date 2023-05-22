using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    //public void Mainkan()
    //{
    //    SceneManager.LoadScene("Battle");
    //}
    //
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    
    public void Seting()
    {
        SceneManager.LoadScene("Setting");
    }
     public void ReloadCurrentScene()
    {
        var currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    //private void OnEnable()
    //{
    //    var CurreScene = SceneManager.GetActiveScene();
    //    int currelevel = int.Parse(CurreScene.name.Split("Level1 ")[1]);
    //    int nextLevel = currelevel + 1;
    //
    //    var nextSceneBuildIndex = SceneUtility.GetBuildIndexByScenePath("Level1 " + nextLevel);
    //    Debug.Log(nextSceneBuildIndex);
    //    if (nextSceneBuildIndex == -1)
    //    {
    //        this.gameObject.SetActive(false);
    //    }
    //}
    //
    //public void NextLevel()
    //{
    //    var CurreScene = SceneManager.GetActiveScene();
    //    int currelevel = int.Parse(CurreScene.name.Split("Level1 ")[1]);
    //    int nextLevel = currelevel + 1;
    //    SceneManager.LoadScene("Level1 " + nextLevel);
    //}
    public AudioSource Backsound;
    public void backsoundOnOff()
    {
        AudioSource bgSound = Backsound.GetComponent<AudioSource>();

        if (bgSound.mute == true)
        {
            bgSound.mute = false;
        }
        else
        {
            bgSound.mute = true;
        }
    }
    public void main()
    {
        SceneManager.LoadScene("Level2");
    }

    public void play()
    {
        SceneManager.LoadScene("Level1");
    }

    //public AudioSource Backsound;
    //
    //public void backsoundOnOff()
    //{
    //    AudioSource bgSound = Backsound.GetComponent<AudioSource>();
    //
    //    if (bgSound.mute == true)
    //    {
    //        bgSound.mute = false;
    //    }
    //    else
    //    {
    //        bgSound.mute = true;
    //    }
    //}
    //
}
