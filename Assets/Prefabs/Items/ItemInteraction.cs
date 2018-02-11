using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInteraction : Interaction {

    public BaseItem item;
	
    public override void interact()
    {
        getPlayer().addToInventory(this.item.getName(), item.getRelVal(), item.gameObject);
        this.gameObject.SetActive(false);
    }

    public override void displayPrompt(RaycastHit hit, Player player)
    {
        setHit(hit);
        setPlayer(player);
        seen = true;
        display();
    }


    public override void display ()
    {
        getUI().displayText("Click to interact");
    }


}
