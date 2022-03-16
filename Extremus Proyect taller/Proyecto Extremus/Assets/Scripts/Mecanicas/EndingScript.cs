using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScript: MonoBehaviour
{
    public GoToMain goToMain;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EndGame();
    }
    public void EndGame()
    {
       if(goToMain.contador==1)
        {
            Debug.Log("TERMINSASTE!!!!");
        }
    }
}
