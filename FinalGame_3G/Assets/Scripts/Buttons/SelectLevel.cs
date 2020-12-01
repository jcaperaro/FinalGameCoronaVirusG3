using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void selectLevel() 
    {
        switch (this.gameObject.name) 
        {
            case "LevelOne":
                SceneManager.LoadScene("Level1");
                break;
            case "LevelTwo":
                SceneManager.LoadScene("Level2");
                break;
        }
    }
}
