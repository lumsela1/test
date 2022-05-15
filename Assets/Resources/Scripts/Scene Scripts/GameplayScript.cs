using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameplayScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    private float actScore = 1000;

    bool levelCcmplete = false;
    
    void loadNextLevel(){
        SceneManager.LoadSceneAsync("Lesson 2", LoadSceneMode.Single);
    }

    void Update() {
        PersistentData.Instance.SetScore((int)Mathf.Round(actScore));

        if (!levelCcmplete){
            actScore -= 1 * Time.fixedDeltaTime;
        }

        score.SetText("Score: " + Mathf.Round(actScore));

    }   

    void decreaseScore(int value){
        print(actScore);
        actScore -= value;
        print(actScore);
    }

    void won(){
        levelCcmplete = true;
    }
}
