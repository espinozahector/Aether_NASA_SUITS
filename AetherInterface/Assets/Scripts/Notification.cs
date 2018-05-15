using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour {

    static Queue<Notification> queue;
    static Notification current;

    public Vector3 direction;
    public float speed = 0.5f;
    public float duration = 0.25f;
    public float hold = 2.0f;

    float timer;

	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= duration) {
            transform.position = transform.position + direction * speed * Time.deltaTime;
        } else if (timer > duration + hold) {
            KillCurrent();
        }

        timer += Time.deltaTime;
	}

    public static void Issue(string header, string msg, int lvl)
    {
        if (queue == null) {
            queue = new Queue<Notification>();
        }

        GameObject noti = (GameObject)Instantiate(Resources.Load("Notification"));
        
        noti.transform.Find("Canvas/Notification Pane/Header").GetComponent<Text>().text = header;
        noti.transform.Find("Canvas/Notification Pane/Body").GetComponent<Text>().text = msg;
        noti.SetActive(false);


        queue.Enqueue(noti.GetComponent<Notification>());
        Next();
    }

    public static void KillCurrent() {
        Destroy(current.gameObject);
        current = null;
        Next();
    }

    public static void Next() {
        if (current == null && queue.Count > 0) {
            current = queue.Dequeue();
            GameObject obj = current.gameObject;

            Quaternion rot = Quaternion.LookRotation(Camera.main.transform.forward, Vector3.Cross(Camera.main.transform.forward, Vector3.right));
            obj.GetComponent<Notification>().direction = rot * Vector3.up;
            obj.transform.position = Camera.main.transform.position + rot * new Vector3(0.0f, -0.25f, 0.25f);
            obj.transform.rotation = rot * Quaternion.Euler(30.0f, 0.0f, 0.0f);
            obj.SetActive(true);
        }
    }
}
