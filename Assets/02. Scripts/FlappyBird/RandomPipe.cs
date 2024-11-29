using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RendomPipeMap : MonoBehaviour
{
    public enum PIPE_TYPE { TOP, BOTTOM, DOUBLE }
    public PIPE_TYPE pipeType;

    public GameObject[] pipes;
    public float pipeSpeed = 0.05f;

    void Start()
    {
        RandomPipeType();
    }

    private void RandomPipeType()
    {
        var randomPipeType = Random.Range(0, 3);

        pipeType = (PIPE_TYPE)randomPipeType;

        //Random Height
        float randomHeight = Random.Range(-1f, 1f);
        pipes[0].transform.position = new Vector3(pipes[0].transform.position.x, pipes[0].transform.position.y + randomHeight, pipes[0].transform.position.z);
        pipes[1].transform.position = new Vector3(pipes[1].transform.position.x, pipes[1].transform.position.y+ randomHeight, pipes[1].transform.position.z);

        ActivePipe();
    }

    private void ActivePipe()
    {
        if (pipeType == PIPE_TYPE.BOTTOM)
        {
            pipes[0].SetActive(true);
            pipes[1].SetActive(false);
        }
        else if (pipeType == PIPE_TYPE.TOP)
        {
            pipes[0].SetActive(false);
            pipes[1].SetActive(true);
        }
        else if (pipeType == PIPE_TYPE.DOUBLE)
        {
            pipes[0].SetActive(true);
            pipes[1].SetActive(true);
        }
    }

    void Update()
    {
        foreach (var pipe in pipes)
        {
            pipe.transform.position -= Vector3.right * pipeSpeed;

            if (pipe.transform.position.x <= -10f)
            {
                RandomPipeType();
                pipe.transform.position = new Vector3(10f, pipe.transform.position.y, pipe.transform.position.z);
            }
        }
    }
}