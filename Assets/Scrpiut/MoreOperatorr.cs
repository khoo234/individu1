using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreOperatorr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int x = 1;
        //int y = 2;
        //bool result = x == y;
        //bool result = x != y;

        //string playerName = null;
        //bool result = playerName != null;

        //int nextlevelxp = 300;
        //int playeronexp = 185;
        //bool result = playeronexp > nextlevelxp;

        //int level = 5;
        //int levelcap = 20;
        //bool result = level < levelcap;

        //int points = 100;
        //int highscore = 100;
        //bool result = !(points <= highscore);


        //Debug.Log(!result);
        //Debug.Log(result);

        //result = !result;
        //debug.Log(result);


        int coins = 100;
        int totallive = 3;
        int maxlive = 10;
        bool ispremiummember = false;


        bool shouldincreasedifficulty = !ispremiummember && totallive > 5;
        Debug.Log(shouldincreasedifficulty);

        bool shouldincreaselifecount = coins >= 100 && totallive < maxlive; 
        Debug.Log(shouldincreaselifecount);

        string firstname = null;
        bool isUpperCase = firstname != null && firstname.ToUpper() == "VEGETARIANZOMBIE";
        Debug.Log(isUpperCase);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
