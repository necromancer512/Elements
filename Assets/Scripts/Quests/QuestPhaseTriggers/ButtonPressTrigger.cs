﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/*
 *  Trigger is remarkably similar to the ReturnItem extension of interactable.
 */
class ButtonPressTrigger : QuestTrigger
{
    //Assumes collisions will occur during a player press.
    // void OnCollisionEnter(Collision other)
    // {
    //     if (other.gameObject.tag == "Player")
    //     {
    //     	Debug.Log("Hit Player");
    //         AdvanceQuest();
    //     }
    // }

    public override void enableTrigger()
    {
        gameObject.tag = "Button";
    }

    public override void disableTrigger()
    {
        gameObject.tag = "Untagged";
        _hideButtonHint();
    }

    public void pushButton()
    {
        AdvanceQuest();
    }
}
