using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		_timeDelay = Time.deltaTime;
		_startTrigger = 0;
	}

	private float _startTrigger;

	private float _timeDelay;

	private const float level = 0.02f;

	private void floating()
	{
		_startTrigger += _timeDelay;
		transform.Translate (Vector3.up*Mathf.Sin (_startTrigger * 2) * level);
	}

	void onMouseDrag()
	{
		transform.position += Vector3.right * Time.deltaTime * Input.GetAxis ("Mouse X");
		transform.position+=Vector3.up*Time.deltaTime*Input.GetAxis("Mouse Y");
	}

	// Update is called once per frame
	void Update () {
		floating ();
	}
}
