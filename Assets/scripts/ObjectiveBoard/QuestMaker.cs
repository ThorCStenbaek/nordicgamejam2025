using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene switching

public class QuestMaker : MonoBehaviour
{
    public ObjectiveUI objectiveUI;

    [Tooltip("Name of the scene to load when all objectives are completed.")]
    public string sceneToLoadOnComplete;

    void Start()
    {
        if (objectiveUI == null)
        {
            Debug.LogWarning("ObjectiveUI reference not set in QuestMaker.");
            return;
        }

        // Set the callback for when all objectives are complete
       // objectiveUI.SetOnAllObjectivesCompleteCallback(OnAllObjectivesComplete);

    }


     public void Day3Work() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("WORK", "Go to work");
             //SceneManager.LoadScene("Afternoon1");
        objectiveUI.SetOnAllObjectivesCompleteCallback(Day3WorkComplete);

    }
    public void Day3WorkComplete(){
                //load scene
        SceneManager.LoadScene("Afternoon3");
    }
        public void Day3(){
                            
                            objectiveUI.AddObjective("SHOW", "Take a shower");
                          objectiveUI.AddObjective("SINK", "Brush your teeth bro");
                          objectiveUI.AddObjective("BREAKFAST", "Eat breakfast");


  

                                objectiveUI.SetOnAllObjectivesCompleteCallback(Day3Work);
    }


    public void Day1(){
                            
                            objectiveUI.AddObjective("SHOW", "Take a shower");
                          objectiveUI.AddObjective("SINK", "Brush your teeth bro");
                          objectiveUI.AddObjective("BREAKFAST", "Eat breakfast");


  

                                objectiveUI.SetOnAllObjectivesCompleteCallback(Day1Work);
    }


        public void Day2(){
                            
                            objectiveUI.AddObjective("SHOW", "Take a shower");
                          objectiveUI.AddObjective("SINK", "Brush your teeth bro");
                          objectiveUI.AddObjective("BREAKFAST", "Eat breakfast");


  

                                objectiveUI.SetOnAllObjectivesCompleteCallback(Day2Work);
    }


        public void Day2Work() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("WORK", "Go to work");
             //SceneManager.LoadScene("Afternoon1");
        objectiveUI.SetOnAllObjectivesCompleteCallback(Day2WorkComplete);

    }

        public void Day2WorkComplete(){
                //load scene
        SceneManager.LoadScene("Afternoon2");
    }


    public void Afternoon1(){
        /*
        Afternoon
Appear in order:
You should listen back to the recording of today’s session
Make some notes about your conclusions
Brush your teeth
Go to bed
*/

objectiveUI.AddObjective("NOTES", "Make some notes");
objectiveUI.AddObjective("SINK", "Brush your teeth");
objectiveUI.AddObjective("BREAKFAST", "Eat Dinner");

objectiveUI.SetOnAllObjectivesCompleteCallback(Afternoon1Done);

    }


        public void Afternoon2(){
        /*
        Afternoon
Appear in order:
You should listen back to the recording of today’s session
Make some notes about your conclusions
Brush your teeth
Go to bed
*/

objectiveUI.AddObjective("NOTES", "Make some notes");
objectiveUI.AddObjective("SINK", "Brush your teeth");
objectiveUI.AddObjective("BREAKFAST", "Eat Dinner");

objectiveUI.SetOnAllObjectivesCompleteCallback(Afternoon2Done);

    }

            public void Afternoon2Done() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("BED", "Go to bed");
        objectiveUI.SetOnAllObjectivesCompleteCallback(afternoon2Complete);

    }

        public void afternoon2Complete(){
        //load scene
        SceneManager.LoadScene("nightmarescene_2");
    }



    /*33333*/


      public void Afternoon3(){
        /*
        Afternoon
Appear in order:
You should listen back to the recording of today’s session
Make some notes about your conclusions
Brush your teeth
Go to bed
*/

objectiveUI.AddObjective("NOTES", "Make some notes");
objectiveUI.AddObjective("SINK", "Brush your teeth");
objectiveUI.AddObjective("BREAKFAST", "Eat Dinner");

objectiveUI.SetOnAllObjectivesCompleteCallback(Afternoon3Done);

    }

            public void Afternoon3Done() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("BED", "Go to bed");
        objectiveUI.SetOnAllObjectivesCompleteCallback(afternoon3Complete);

    }

        public void afternoon3Complete(){
        //load scene
        SceneManager.LoadScene("nightmarescene_3");
    }

        public void Afternoon1Done() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("BED", "Go to bed");
        objectiveUI.SetOnAllObjectivesCompleteCallback(afternoon1Complete);

    }


    public void onNote(){
        objectiveUI.CompleteObjective("NOTES");
    }

    public void afternoon1Complete(){
        //load scene
        SceneManager.LoadScene("nightmarescene_1");
    }


public void Nightmare1(){
    objectiveUI.AddObjective("TOILET", "go to the toilet");
    objectiveUI.SetOnAllObjectivesCompleteCallback(Nightmare1Complete);
}

public void Nightmare2(){
    objectiveUI.AddObjective("TOILET", "go to the toilet");
    objectiveUI.SetOnAllObjectivesCompleteCallback(Nightmare2Complete);
}

    public void Nightmare2Complete() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("SON", "Check on your son");
        objectiveUI.SetOnAllObjectivesCompleteCallback(Nightmare2WakeUp);
    }

    public void Nightmare2WakeUp(){
          objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("BED", "WAKE UP");
        objectiveUI.SetOnAllObjectivesCompleteCallback(NightmareLOADNEXT2);
    }	




//NIGHTMARE 3

//elder signs 
public void onEldersign1(){
    objectiveUI.CompleteObjective("ELDERSIGN 1");
}
public void onEldersign2(){
    objectiveUI.CompleteObjective("ELDERSIGN 2");
}
public void onEldersign3(){
    objectiveUI.CompleteObjective("ELDERSIGN 3");
}
public void onEldersign4(){
    objectiveUI.CompleteObjective("ELDERSIGN 4");
}
public void onEldersign5(){
    objectiveUI.CompleteObjective("ELDERSIGN 5");
}

public void Nightmare3(){
    objectiveUI.AddObjective("ELDERSIGN 1", "find eldersign 1");
     objectiveUI.AddObjective("ELDERSIGN 2", "find eldersign 2");
      objectiveUI.AddObjective("ELDERSIGN 3", "find eldersign 3");
       objectiveUI.AddObjective("ELDERSIGN 4", "find eldersign 4");
        objectiveUI.AddObjective("ELDERSIGN 5", "find eldersign 5");
    objectiveUI.SetOnAllObjectivesCompleteCallback(Nightmare3Complete);
}

    public void Nightmare3Complete() {
        objectiveUI.ClearObjectives();
        
        SceneManager.LoadScene("day1");
        //objectiveUI.SetOnAllObjectivesCompleteCallback(Nightmare3WakeUp);
    }

    public void Nightmare3WakeUp(){
          objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("BED", "WAKE UP");
        objectiveUI.SetOnAllObjectivesCompleteCallback(NightmareLOADNEXT3);
    }	

            public void NightmareLOADNEXT3() {
   SceneManager.LoadScene("day1");
    }



            public void NightmareLOADNEXT2() {
   SceneManager.LoadScene("day3");
    }

    public void onSon(){
        objectiveUI.CompleteObjective("SON");
    }

public void onToilet(){
    objectiveUI.CompleteObjective("TOILET");
}

//nightmare1 complete

    public void Nightmare1Complete() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("BED", "WAKE UP");
        objectiveUI.SetOnAllObjectivesCompleteCallback(NightmareLOADNEXT);
    }

        public void NightmareLOADNEXT() {
   SceneManager.LoadScene("day2");
    }

    public void Day1Work() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("WORK", "Go to work");
             //SceneManager.LoadScene("Afternoon1");
        objectiveUI.SetOnAllObjectivesCompleteCallback(Day1WorkComplete);

    }
    public void Day1WorkComplete(){
                //load scene
        SceneManager.LoadScene("Afternoon1");
    }

    public void onShower(){
          objectiveUI.CompleteObjective("SHOW");
         Debug.LogWarning("SHOWER TIME");
           objectiveUI.LogAllObjectiveKeys();
      
    }

    public void onSink(){
        objectiveUI.CompleteObjective("SINK");
    }

    public void onBreakfast(){
        objectiveUI.CompleteObjective("BREAKFAST");
    }

    public void onWork(){
        objectiveUI.CompleteObjective("WORK");
    }

    public void onBed(){
        objectiveUI.CompleteObjective("BED");
    }


    public void OnKeyPickup()
    {
        objectiveUI.CompleteObjective("KEY");
    }

    public void OnPowerActivated()
    {
        objectiveUI.CompleteObjective("POWER");
    }

    private void OnAllObjectivesComplete()
    {
        Debug.Log("All objectives completed!");

        if (!string.IsNullOrEmpty(sceneToLoadOnComplete))
        {
            Debug.Log($"Loading scene: {sceneToLoadOnComplete}");
            SceneManager.LoadScene(sceneToLoadOnComplete);
        }
        else
        {
            Debug.Log("No scene specified to load.");
        }
    }
}
