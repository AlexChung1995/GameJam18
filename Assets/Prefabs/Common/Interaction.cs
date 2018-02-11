using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    public GameObject UI;
    private UI ui;
    protected bool seen;
    protected RaycastHit hit;
    protected Player player;
    
	// Use this for initialization
	void Start () {
        this.ui = UI.GetComponent<UI>();
	}
	
	// Update is called once per frame
	void Update () {
		if (seen)
        {
            if (Input.GetMouseButtonDown(0))
            {
                interact();
            }
        }
        seen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("onTriggerEnter");   
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("onTriggerExit");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("onTriggerStay");
    }

    public virtual void interact()
    {
        Debug.Log("starting place");
        GameObject obj = this.player.getFromInventory();
        obj.transform.position = new Vector3(this.hit.point.x, this.hit.point.y + obj.GetComponentInChildren<Collider>().bounds.size.y*5/4, this.hit.point.z);
        obj.SetActive(true);
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            obj.transform.GetChild(i).gameObject.SetActive(true);
            obj.transform.GetChild(i).gameObject.transform.localPosition = Vector3.zero;
        }
        Debug.Log(this.transform.position.ToString());
        Debug.Log(obj.GetComponentInChildren<Collider>().bounds.size.y);
        Debug.Log(obj.transform.position.ToString());
    }

    public virtual void displayPrompt(RaycastHit hit, Player player)
    {
        this.player = player;
        this.hit = hit;
        seen = true;
        display();
    }

    public void setHit(RaycastHit hit)
    {
        this.hit = hit;
    }

    public RaycastHit getHit()
    {
        return this.hit;
    }

    public void setPlayer(Player player)
    {
        this.player = player;
    }

    public Player getPlayer()
    {
        return this.player;
    }
    
    public UI getUI()
    {
        return this.ui;
    }

    public void setUI(UI ui)
    {
        this.ui = ui;
    }

    public virtual void display()
    {
        this.ui.displayText("");
    }

}
