using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private string current;
    public Camera playerCamera;
    public float speed;
    public float viewRange;
    Dictionary<string, GameObject> inventory;
    private float resolution;
	// Use this for initialization
	void Start () {
        this.current = "";
        this.resolution = 30.0f;
        this.inventory = new Dictionary<string, GameObject>();
        playerCamera.transform.localPosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        view();
        if (Input.GetButtonDown("Jump"))
        {
            toggleToNextObj();
        }
	}

    private void FixedUpdate()
    {
        move();
    }

    private void move()
    {
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        float aroundY = playerCamera.transform.rotation.eulerAngles.y;
        float side = speed * Input.GetAxis("Vertical") * Mathf.Cos(Mathf.PI * aroundY / 180);
        float forward = speed * Input.GetAxis("Vertical") * Mathf.Sin(Mathf.PI * aroundY / 180);
        Vector3 move = new Vector3(forward, 0, side);
        this.GetComponent<Rigidbody>().AddForce(move * speed);
    }

    private void toggleToNextObj()
    {
        string first = "";
        Dictionary<string, GameObject>.KeyCollection keyColl = this.inventory.Keys;
        bool found = false;
        bool foundFirst = false;
        Debug.Log("toggle");
        foreach (string key in keyColl)
        {
            Debug.Log(key);
            if (!foundFirst)
            {
                first = key;
                foundFirst = true;
            }
            if (found == true)
            {
                this.current = key;
                return;
            }
            if (key == this.current)
            {
                found = true;
            }
        }
        this.current = first;
    }

    private void view()
    {
        Ray ray = new Ray(transform.position, playerCamera.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, viewRange,1))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            GameObject parent = hit.collider.gameObject.transform.parent.gameObject;
            Interaction interact = (Interaction) hit.collider.gameObject.transform.parent.gameObject.GetComponent(typeof(Interaction)) as Interaction;
            if (interact != null)
            {
                interact.displayPrompt(hit,this);
            }
        }
    }

    public GameObject getFromInventory()
    {
        GameObject obj = null;
        if (this.inventory.TryGetValue(this.current, out obj))
        {
            this.inventory.Remove(this.current);
            Dictionary<string, GameObject>.KeyCollection keyColl = this.inventory.Keys;
            this.current = "";
            foreach( string key in keyColl)
            {
                this.current = key;
            }
            return obj;
        }
        return null;
    }

    public string getCurrent()
    {
        return this.current;
    }

    public void clearInventory()
    {
        this.inventory = new Dictionary<string, GameObject>();
    }

    public void addToInventory(string name, float relVal, GameObject obj)
    {
        this.current = name;
        this.inventory.Add(name, obj);
        this.resolution += relVal;
        Debug.Log(this.inventory.ToString());
    }

    public float getRes()
    {
        return this.resolution;
    }

    private void OnTriggerEnter(Collider other)
    {
           
    }

    private void OnTriggerExit(Collider other)
    {
    
    }

}
