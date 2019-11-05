using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIKnowledgeManager : MonoBehaviour
{
    Dictionary<string, Knowledge> dictionary;

    void Start()
    {
        dictionary = new Dictionary<string, Knowledge>();
    }

    void Update()
    {
        
    }

    void AddKnowledge(string name, Knowledge knowledge)
    {
        Knowledge tmp_knowledge = dictionary[name];

        if(tmp_knowledge == null)
        {
            dictionary.Add(name, new Knowledge(tmp_knowledge.game_object, tmp_knowledge.position, tmp_knowledge.time_stamp, tmp_knowledge.past_memory));
        }
        else
        {
            tmp_knowledge.Update();
        }
    }
}
