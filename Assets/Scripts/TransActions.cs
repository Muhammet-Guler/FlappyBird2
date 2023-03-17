using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransActions : MonoBehaviour
{
    public GameManager ManagerGame;
    public UnityEngine.UI.Text FirstNumber, SecondNumber, Operator, Answer, Conclusion;
    public UnityEngine.UI.InputField ConclusionBtn;
    int N1, N2, OperatorSign, TransactionResult;
    // Start is called before the first frame update
    void Start()
    {
        Questions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    public void AnswerControl()
    {
        if (int.Parse(Answer.text)==TransactionResult)
        {
            Conclusion.text = "Doðru";
            ManagerGame.UpdateTenScore();
        }
        else
        {
            Conclusion.text = "Yanlýþ";
        }
    }
    public void Questions()
    {
        ConclusionBtn.text = "";
        N1 = Random.Range(1, 10);
        N2= Random.Range(1, 10);
        OperatorSign= Random.Range(1, 5);

        switch (OperatorSign)
        {
            case 1:
                Operator.text = "+";
                TransactionResult = N1 + N2;
                break;
            case 2:
                Operator.text = "-";
                TransactionResult = N1 - N2;
                break;
            case 3:
                Operator.text = "*";
                TransactionResult = N1 * N2;
                break;
            case 4:
                Operator.text = "/";
                TransactionResult = N1 / N2;
                break;
        }
        FirstNumber.text = N1 + "";
        SecondNumber.text = N2 + "";
    }
}
