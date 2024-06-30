using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject CanvasLose;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void lose()
    {
        CanvasLose.SetActive(true);
        Time.timeScale = 0;
    }
    public void reload()
    {
        SceneManager.LoadScene(0);
    }
}
