using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject TitleText;
    [SerializeField] GameObject TimeManager;
    [SerializeField] GameObject ClicktoStart;
    [SerializeField] GameObject ExplanationText1;
    [SerializeField] GameObject ExplanationText2;

    //public bool PlumFlag = false; //ステージ遷移用フラグ
    //public bool CherryFlag = false;
    //public bool WatermelonFlag = false; 

    public int PlumStage = 0;
    public int CherryStage = 0;
    public int WatermelonStage = 0;

    public void OnClickSelectStageButton() //SelectStageの画面に遷移
    {
        SceneManager.LoadScene("SelectStage");
    }

    public void ExplanationButton() //操作の説明画面を表示
    {
        TitleText.SetActive(false);
        TimeManager.SetActive(false);
        ClicktoStart.SetActive(false);
        gameObject.SetActive(false);
        ExplanationText1.SetActive(true);
        ExplanationText2.SetActive(true);
    }

    public void OnclickFirstStageButton() //Plum-1の画面に遷移
    {
        SceneManager.LoadScene("Plum-1");
        //PlumFlag = true;
        PlumStage++;
    }

    public void OnclickCherryStageButton()
    {
        SceneManager.LoadScene("Cherry-1");
        //CherryFlag = true;
        CherryStage++;
    }

    public void OnclickWatermelonStageButton()
    {
        SceneManager.LoadScene("Watermelon-1");
        //WatermelonFlag = true;
        WatermelonStage++;
    }

    public void ClickPlum2Button()
    {
        SceneManager.LoadScene("Plum-2");
    }

    public void ClickPlum3Button()
    {
        SceneManager.LoadScene("Plum-3");
    }

    public void ClickCherry2Button()
    {
        SceneManager.LoadScene("Cherry-2");
    }

    public void ClickCherry3Button()
    {
        SceneManager.LoadScene("Cherry-3");
    }

    public void ClickWatermelon2Button()
    {
        SceneManager.LoadScene("Watermelon-2");
    }

    public void ClickWatermelon3Button()
    {
        SceneManager.LoadScene("Watermelon-3");
    }

    public void CredisButton()//Creditの画面に遷移
    {
        SceneManager.LoadScene("Credit");
    }

    public void Return() //Titleの画面に遷移
    {
        SceneManager.LoadScene("Title");
    }
}
