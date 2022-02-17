using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{

    public GameObject pauseManu;
    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !Dead.IsDead && !isPaused)
        {             
            pauseManu.SetActive(true);
            isPaused = true;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && !Dead.IsDead && isPaused)
        {    
            pauseManu.SetActive(false);
            isPaused = false;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ContineuGame()
    {
        pauseManu.SetActive(false);
        isPaused = false;
    }

    public void TryAgain()
    {
        Dead.IsDead = false;
        SceneManager.LoadScene(0);
    }
}
