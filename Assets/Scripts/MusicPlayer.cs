using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	private static MusicPlayer instance = null;

	public static MusicPlayer Instance { get { return instance; } }

	private void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);	
		}
	}

	// Use this for initialization
	void Start () {
	}

}
