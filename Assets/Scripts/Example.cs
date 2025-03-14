using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;


public class Example : MonoBehaviour
{
    string myWord = "stuff";
    [SerializeField] TextAsset myText;
    public int[,] myGrid = 
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9},
    };
    string[] myNames = { "Steve", "Bob", "Jeff" };
    char[] word = { 'h', 'e', 'l', 'l', 'o' };

    List<int> numberList = new List<int>();

    Dictionary<int, string> myDictionary = new Dictionary<int, string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(myText.text);
        string[] guesses = myText.text.Split('\n');
        Debug.Log(guesses[3]);

        int choice = Random.Range(0, guesses.Length);

        numberList.Add(0);
        for (int i = 0; i <= 100; i++)
        {
            numberList.Add(i);
        }

        //myDictionary.Add(10, "Jeff");

        var data = new Dictionary<string, string>()
        {

        };

        foreach(KeyValuePair<string, string> kvp in data)
        {

        };

        var myDictionary = new Dictionary<char, int>();

        foreach(char c in myWord)
        {
            if (myDictionary.ContainsKey(c))
            {
                myDictionary[c] += 1;
            }
            else
            {
                myDictionary.Add(c, 1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
