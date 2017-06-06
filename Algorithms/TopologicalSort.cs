// http://blog.csdn.net/lgx040605112/article/details/5247775
using System;
using System.Collections;
using System.Collections.Generic;
public class GraphNode
{
    public int InDegree;
    public int OutDegree;
    public string NodeName;
}

 
public class GraphDirecTopoSorted
{
    private List<GraphNode> nodeList;   //节点链表
    private List<KeyValuePair<GraphNode, GraphNode>> edgeList;  //边链表

    public GraphDirecTopoSorted(List<GraphNode> node, List<KeyValuePair<GraphNode, GraphNode>> edge)
    {
        this.nodeList = node;
        this.edgeList = edge;
    }

    /// 计算节点的入度出度
    private void NodeInOutDegree()
    {
        foreach (GraphNode node in nodeList)
        {
            int inDegree = 0;
            int outDegree = 0;
            foreach (KeyValuePair<GraphNode, GraphNode> edge in edgeList)
            {
                if (edge.Value.NodeName == node.NodeName)
                {
                    inDegree++;
                }
                if (edge.Key.NodeName == node.NodeName)
                {
                    outDegree++;
                }
            }
            node.InDegree = inDegree;
            node.OutDegree = outDegree;
        }
    }

    /// 是否有环路，有则返回NULL，否则返回入度为零的节点
    private GraphNode HaveCycle()
    {
        GraphNode tempNode = null;
        NodeInOutDegree();
        foreach (GraphNode node in nodeList)
        {
            if (node.InDegree == 0)
            {
                tempNode = node;
            }
        }
        return tempNode;
    }

    /// 删除节点对应的边
    private void RemoveGraphEdge(GraphNode node)
    {
        for (int i = 0; i < edgeList.Count; )
        {
            if (edgeList[i].Key == node)
            {
                edgeList.RemoveAt(i);
            }
            else
            {
                i++;
            }
        }
    }

    /*有向图的排序
        记录每个点的入度。
        将入度为0的顶点加入队列。
        依次对入度为0的点进行删边操作，同时将新得到的入度为零的点加入队列。
        重复上述操作，直至队列为空。
    */
    public List<GraphNode> TopoSorted()
    {
        List<GraphNode> sortResult = new List<GraphNode>();
        while (nodeList.Count > 0)
        {
            GraphNode tempNode = HaveCycle();
            if (tempNode != null)
            {
                sortResult.Add(tempNode);
                nodeList.Remove(tempNode);
                RemoveGraphEdge(tempNode);
            }
        }
        return sortResult;
    }
}