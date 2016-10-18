/*
207. Course Schedule

There are a total of n courses you have to take, labeled from 0 to n - 1.

Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]

Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?

For example:

2, [[1,0]]
There are a total of 2 courses to take. To take course 1 you should have finished course 0. So it is possible.

2, [[1,0],[0,1]]
There are a total of 2 courses to take. To take course 1 you should have finished course 0, and to take course 0 you should also 
have finished course 1. So it is impossible.
*/
using System;
using System.Collections.Generic;

public class Solution207 {
    private bool[] visited;
    public bool CanFinish(int numCourses, int[,] prerequisites) {
        visited = new bool[numCourses];
        var res = new List();

        for (int i = 0; i < numCourses; i++)
        {
            if (!visited[i])
            {
                var returns = FindOrderDFS(numCourses, prerequisites, i, new List());
                if(returns == null) return null;
                res.AddRange(returns);
            }
        }

        res.Reverse();
        return res.ToArray();
    }

    private int[] FindOrderDFS(int numCourses, int[,] prerequisites, int start, List parents)
    {
        var res = new List<int>();

        int rows = prerequisites.GetLength(0);
        
        for (int i = 0; i < rows; i++)
        {
            if (prerequisites[i, 1] == start && !visited[prerequisites[i, 0]])
            {
                if (parents.Contains(prerequisites[i, 0]))
                {
                    return null;
                }
                parents.Add(start);
                var rest = FindOrderDFS(numCourses, prerequisites, prerequisites[i, 0], parents);

                if(rest == null)
                {
                    return null;
                }
                res.AddRange(rest);
            }
        }

        res.Add(start);
        visited[start] = true;

        return res.ToArray();
    }
}