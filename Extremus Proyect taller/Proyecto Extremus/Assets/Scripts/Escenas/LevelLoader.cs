using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float timetransition=1f;
    public GameObject myobject;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            //SceneManager.LoadScene("Islas");
            LoadNextLevel();
            

        }
       
    }
    /*public void LoadScene(string scenemane)
    {
        StartCoroutine(Loadlevel(SceneManager.LoadScene(scenemane));
    }*/
    
    public void LoadNextLevel()
    {
        StartCoroutine(Loadlevel(SceneManager.GetActiveScene().buildIndex /*+ 1*/ ));

        
    }

    IEnumerator Loadlevel(int levelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(timetransition);

        //SceneManager.LoadScene(levelIndex);

        myobject.SetActive(false);
    }
}
