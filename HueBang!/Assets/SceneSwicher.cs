using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneSwicher : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {

        Event e = Event.current;
        if (e.button == 0 && e.isMouse)
        {
            Debug.Log("111");
            SceneManager.LoadScene("Ending");
        }
    }
}
