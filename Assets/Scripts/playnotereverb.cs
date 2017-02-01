using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playnotereverb : MonoBehaviour {
	public KeyCode mappedkey;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (mappedkey)) {
			StartCoroutine (PlayNote ());
		} else if (Input.GetKeyDown(KeyCode.Space)) {
			this.GetComponent<AudioSource> ().Stop ();
		}
	}

	void OnMouseDown(){
		StartCoroutine (PlayNote());
	}

	IEnumerator PlayNote(){	
		this.GetComponent<AudioSource> ().Play ();
		this.gameObject.transform.localPosition -= new Vector3(0, 0.2f, 0);
		yield return new WaitForSeconds (0.05f);
		this.gameObject.transform.localPosition += new Vector3(0, 0.2f, 0);
	}
		
}
