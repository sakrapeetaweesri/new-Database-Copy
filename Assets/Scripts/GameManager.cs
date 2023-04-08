using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;

 

    public GameObject spawnPos;
    public GameObject rallyPos;

 

    //resource
    public int money;
    public int staffNum;
    public int wheat;
    public int melon;
    public int corn;
    public int apple;

 

    public static GameManager instance;
    public int dailyWage;

 

    public List<Structure> structures = new List<Structure>();
    public List<Staff> staff = new List<Staff>();

 

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        GenerateCandidate();
        money = 25000;
        wheat = 0;
        UI.instance.UpdateHeaderPanel();
    }

 

    // Update is called once per frame
    void Update()
    {

    }

 

    private void GenerateCandidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();

 

            s.InitCharID(i);
            s.ChangeCharSkin();

 

            s.SetToWalk(rallyPos.transform.position);
        }
    }

 

    public void HireStaff(Staff st)
    {
        money -= st.dailyWage;
        staff.Add(st);
    }

 

    public void SendStaff(GameObject target)
    {
        Farm f = target.GetComponent<Farm>();

 

        if (f.WorkingStaff.Count >= f.MaxStaffNum)
            return;

 

        int n = 0;

 

        for (int i = 0; i < staff.Count; i++)
        {
            Staff s = staff[i].GetComponent<Staff>();
            if (staff[i].Workplace == null)
            {
                staff[i].Workplace = target;
                staff[i].SetToWalk(target.transform.position);
                f.WorkingStaff.Add(s);
                n++;
            }

 

            if (n >= f.MaxStaffNum)
                break;
        }
    }
}