// MoveTo.cs
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MoveTo : MonoBehaviour
{
    public Transform goal;
    public LineRenderer line;
    /**/
    NavMeshAgent agent;
    /**/

    int count = 0;

    [System.Obsolete]
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();



        /**/
        agent.destination = goal.position;
        line.gameObject.SetActive(true);
        line.SetWidth(0.3f, 0.3f);
        /**/
    }

    [System.Obsolete]
    void  Update()
    {

        
        Vector3[] _path = agent.path.corners;
        var path = _path;
        line.SetVertexCount(path.Length);
        Debug.Log(goal.position);
            for (int i = 0; i < _path.Length; i++)
            {
                Debug.Log(i);
                line.SetPosition(i, _path[i]+  new Vector3(0,1,0));
                Debug.Log(_path[i]);
            }

        
    

    }

}