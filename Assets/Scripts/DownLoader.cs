using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Xml;

public class DownLoader : MonoBehaviour {

	public WWW www;
	public string url;
	public bool downloaded;

	// Use this for initialization
	void Start () {
	
	}


	void OnGUI(){
		if(GUI.Button(new Rect(0,0,100,100),"GetVid")){
			StartCoroutine("GetVid");
		}

	}



	IEnumerator GetVid(){
		www = new WWW(url);
		yield return www;
		downloaded = www.isDone;
		System.IO.File.WriteAllBytes(Application.dataPath + "/example.mp4", www.bytes);
	}


	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown("escape")){
		Application.Quit();
		}
	}



	
}
