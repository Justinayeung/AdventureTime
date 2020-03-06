using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticClass
{
    public static bool sceneChanged = false; //Bool for checking if the plaque or chest has been visited, so that you can go to god to get the riddle

    public static bool haveAx;
    public static bool havePosion;
    public static bool haveClover;
    public static bool haveAmaranthus;

    public static bool axUsed;
    public static bool posionUsed;
    public static bool cloverUsed;
    public static bool amaranthusUsed;

    public static bool LetterA, LetterI, LetterR = false; //Bools for checking if letters are in the right place, and if they are keep Chest open
    public static bool ChestRidSolved = false; //Checking if chest riddle is solved, if it is don't bring up the panel
    public static bool amaranthusObtained = false; //Using this only for checking if flower has been obtained, if so chest is opened forever

}
