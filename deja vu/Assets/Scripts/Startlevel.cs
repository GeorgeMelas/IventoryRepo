using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Startlevel : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void loadlevel()
    {
        SceneManager.LoadScene(1);
    }
}
