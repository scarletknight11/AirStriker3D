using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {
    public Transform canvas;
	public Transform Player;




	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
	}
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<Controller>().enabled = false;
			Player.GetComponent<MouseLooker>().enabled = false;
			Player.GetComponent<TargetMover>().enabled = false;
			Player.GetComponent<TargetExit>().enabled = false;
			Player.GetComponent<Shooter>().enabled = false;
			Player.GetComponent<SpawnGameObjects>().enabled = false;
			Player.GetComponent<SmoothFollow>().enabled = false;


        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
			Player.GetComponent<Controller>().enabled = true;
			Player.GetComponent<MouseLooker>().enabled = true;
			Player.GetComponent<TargetMover>().enabled = true;
			Player.GetComponent<TargetExit>().enabled = true;
			Player.GetComponent<Shooter>().enabled = true;
			Player.GetComponent<SpawnGameObjects>().enabled = true;
			Player.GetComponent<SmoothFollow>().enabled = true;



        }
    }
}
