using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    //public int temp;
    [SerializeField] private List<Button> _buttonList = new List<Button>();
    //[SerializeField] private Button[][] buttons;
    //public List<Button> buttons3 = new List<Button>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (Button button in _buttonList)
        {
            button.onClick.AddListener(delegate { ShowID(_buttonList.IndexOf(button)); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowID(int id)
    {
        Debug.Log(id);
    }
}
