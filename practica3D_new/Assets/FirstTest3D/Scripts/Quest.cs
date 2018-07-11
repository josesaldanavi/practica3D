using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//serialisable xdXdDXd
[System.Serializable]
public class Quest {

    public readonly string id;
    public string action;
    public string type;
    public int currentAmmount;
    public int targetAmmount;

    public Quest(string id,string action,string type,int targetAmmount){
        this.id = id;
        this.action = action;
        this.type = type;
        this.targetAmmount = targetAmmount;
        currentAmmount = 0;
    }

    public bool check(string action,string type,int ammount=1){
        if(action== this.action && type==this.type){
            currentAmmount += ammount;
            if(currentAmmount == targetAmmount){
                return true;
            }
        }
        return false;
    }

}
