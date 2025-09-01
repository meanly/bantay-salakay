using UnityEngine;
using TMPro;

public class QuestUIManager : MonoBehaviour
{
    public TMP_Text questText;

    // Drag the new conversation object here in the Inspector
    public GameObject QuestDoneActivator;
    public GameObject QuestActivateDelete;

    private void Start()
    {
        questText.gameObject.SetActive(false);
    }

    public void ActivateQuestText()
    {
        questText.text = "Objective: Hanapin ang flashlight at kausapin uli si Kapitan.";
        questText.gameObject.SetActive(true);
    }

    public void CompleteQuestText()
    {
        questText.text = " ";
        questText.gameObject.SetActive(false);
    }

    public void ChangeConvo()

    {
        QuestDoneActivator.gameObject.SetActive(true);
        QuestActivateDelete.gameObject.SetActive(false);
    }
}
                                                 