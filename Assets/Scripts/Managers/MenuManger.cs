using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManger : MonoBehaviour {
    private Canvas canvas;
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Canvas.enbled = !Canvas.enbled;
            Pause();
        }
		
	}
    public void Pause()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
       
    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
