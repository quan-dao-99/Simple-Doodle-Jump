using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayUI : MonoBehaviour {
	public GameObject pauseMenu;
    public GameObject loseMenu;
	[HideInInspector]
    public bool isOpened;
	private UIManager uiManager;

    // Use this for initialization
    private void Awake()
    {
		uiManager = FindObjectOfType<UIManager>();
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        loseMenu.SetActive(false);
        isOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isOpened)
            {
                uiManager.Resume();
                return;
            }
			uiManager.Pause();
        }
    }
}
