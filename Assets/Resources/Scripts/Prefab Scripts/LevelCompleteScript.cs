using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScript : MonoBehaviour
{
    public GameObject canvas;

    void Start(){
        GetComponent<SpriteRenderer>().enabled = false;
    }
    void OnTriggerEnter2D(){
        GetComponent<SpriteRenderer>().enabled = true;
        canvas.SendMessage("won");
        StartCoroutine(LoadGameOver());
    }
    
    IEnumerator LoadGameOver(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadSceneAsync("Lesson 2", LoadSceneMode.Single);
    }
}
