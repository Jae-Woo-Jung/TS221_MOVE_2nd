using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RewardListController : MonoBehaviour
{

    public List<TextMeshProUGUI> guideTexts = new List<TextMeshProUGUI>();
    public List<TextMeshProUGUI> guideTexts_str = new List<TextMeshProUGUI>();

    private void setGuideText()
    {
        for (int i=1; i<guideTexts.Count+1; i++)
        {
            string msg = ChildDataController.RLresult["포인트_"+i].ToString() + "P";
            guideTexts[i-1].text = msg;
            //Debug.Log("dldidldi : " + msg);
            

        }
    }

    private void setGuideText_str()
    {
        for (int i = 1; i < guideTexts_str.Count + 1; i++)
        {
            string msg = ChildDataController.RLresult_str["제목_" + i].ToString();
            guideTexts_str[i - 1].text = msg;
            //Debug.Log("dldidldi_str : " + msg);


        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ChildDataController.receiveRewardList(setGuideText);
        ChildDataController.receiveRewardList_str(setGuideText_str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
