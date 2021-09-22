using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textInput : MonoBehaviour
{
   
  public string[] answers;
   public InputField[] inputField;
    // public GameObject textDisplay;

   // [SerializeField]
    public GameObject[] doors;

   


    public void OnClickClue1()
    {
       if( inputField[0].text == answers[0])
        {
            //door 1 open 
            // door1
          //   doors[0].enabled = true;
           doors[0].SetActive(false);
        }
    }

   // public void Clue2()
    //{
     //   if (inputField[1].text == answers[1])
      /*  {
            //door 1 open 
        }
    }

    public void Clue3()
    {
        if (inputField[2].text == answers[2])
        {
            //door 1 open 
        }
    }

    public void Clue4()
    {
        if (inputField[3].text == answers[3])
        {
            //door 1 open 
        }
    }*/
}
