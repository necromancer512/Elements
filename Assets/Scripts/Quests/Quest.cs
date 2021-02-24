using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest
{
    public QuestName name;

    public List<QuestName> prerequisites;

    public List<( string hint, string image )> phaseHints;

    public int totalPhases;

    public int currentPhase;

    public Quest(QuestName name, List<QuestName> prerequisites, List<( string hint, string image )> phaseHints)
    {  
        this.name = name;
        this.prerequisites = prerequisites;
        this.phaseHints = phaseHints;
        this.totalPhases = phaseHints.Count;
        this.currentPhase = prerequisites.Count > 0 ? -1: 0;

        if (this.currentPhase == 0) EventManager.instance.QuestProgressed( name, 0 );
    }

    public ( string hint, string image ) getPhaseHint()
    {
        return phaseHints[currentPhase];
    }
}