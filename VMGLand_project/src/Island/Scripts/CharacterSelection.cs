using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        characterList=new GameObject[transform.childCount];
        for(int i=0;i<transform.childCount;i++){
            characterList[i]=transform.GetChild(i).gameObject;
        }   
         foreach(GameObject Go in characterList)
             Go.SetActive(false);
             if(characterList[0])
             characterList[0].SetActive(true);
            index=0;   
    }
    public void ToggleLeft(){
        characterList[index].SetActive(false);
        index--;
        if(index<0){
            index=characterList.Length-1;
        }
        characterList[index].SetActive(true);
    }
        public void ToggleRight(){
        characterList[index].SetActive(false);
        index++;
        if(index==characterList.Length){
            index=0;
        }
        characterList[index].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ConfirmButton(){
        SceneManager.LoadScene("Island");
    }
}
