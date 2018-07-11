using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {
    static public QuestManager instance;

    public List<Quest> inactive;
    public List<Quest> active;
    public List<Quest> completed;

	private void Awake()
	{
        if(instance == null){
            instance = this;
        }
	}

	// Use this for initialization
	void Start () {

        inactive = new List<Quest>();
        active = new List<Quest>();
        completed = new List<Quest>();
        //created game quests
        inactive.Add(new Quest("QT01", "obtain", "Fireball", 1,"QT02"));
        inactive.Add(new Quest("QT02", "Destroy", "BasicEnemy", 1));
        //added my first quest to active
        Activate("QT01");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Check (string action, string type){
        foreach(Quest quest in active){
            if(quest.Check(action, type)){
                Debug.Log("Completed" + quest.id);
                removal.Add(quest);
            }
        }
    }
    public void Activate(string id){
        Quest quest = Search(id);
        inactive.Remove(quest);
        active.Add(quest);
    }

    public Quest Search (string id){
       return inactive.Find(quest => quest.id == id);
    }
}
