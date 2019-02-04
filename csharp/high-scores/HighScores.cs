using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{

    private List<int> highScores;
    private List<int> topScores;


    //Calls PersonalTop() when the score list is constructed so that 
    //the O(n) function doesn't need to be called many times in the various
    //other functions that use its results.
    public HighScores(List<int> list)
    {
        highScores = list;
        topScores = this.PersonalTop();
    }

    public List<int> Scores()
    {
        return highScores;
    }

    public int Latest()
    {
        return highScores[highScores.Count-1];
    }

    public int PersonalBest()
    {
        return topScores[0];
    }


    //Loops through entire list, comparing each element with the current top three 
    //scores, replacing and bumping down current top scores. Adds non-negative
    //top values to the return list. 
    public List<int> PersonalTop()
    {
        int top1 = -1;
        int top2 = -1;
        int top3 = -1;
        List<int> topScores = new List<int>();
        for (int i = 0; i < highScores.Count; i++){
            if (highScores[i] > top1){
                top3 = top2;
                top2 = top1;
                top1 = highScores[i];
            } else if (highScores[i] > top2) {
                top3 = top2;
                top2 = highScores[i];
            } else if (highScores[i] > top3) {
                top3 = highScores[i];
            }
        }
        topScores.Add(top1);
        if (top2 != -1) {
            topScores.Add(top2);
        } 
        if (top3 != -1) {
            topScores.Add(top3);
        }
        return topScores;
    }

    public string Report()
    {
        int latest = this.Latest();
        int best = this.PersonalBest();
        int difference = best - latest;
        if(difference == 0){
            return String.Format("Your latest score was {0}. " +
             "That's your personal best!", latest);
        } else {
            return String.Format("Your latest score was {0}. " +
            "That's {1} short of your personal best!", latest, difference);
        }
    }
}