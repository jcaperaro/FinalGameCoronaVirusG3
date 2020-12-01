using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSelectLevel : MonoBehaviour
{
    public void goSelectLevel() 
    {
        SceneManager.LoadScene("SelectLevel");
    }
}
