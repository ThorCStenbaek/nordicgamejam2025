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

    public void Day1(){
                            
                            objectiveUI.AddObjective("SHOW", "Take a shower");
                          objectiveUI.AddObjective("SINK", "Brush your teeth bro");
                          objectiveUI.AddObjective("BREAKFAST", "Eat breakfast");


  

                                objectiveUI.SetOnAllObjectivesCompleteCallback(Day1Work);
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
        SceneManager.LoadScene("Day2");
    }


    public void Day1Work() {
        objectiveUI.ClearObjectives();
        objectiveUI.AddObjective("WORK", "Go to work");
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
