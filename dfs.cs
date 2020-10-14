using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using static System.Math;
using System.Numerics;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.ComponentModel.Design;
//using nint=System.Int32;
class Graph
{
    private int V;
    private List<int>[] adj;
    Graph(int v)
    {
        V = v;
        adj = new List<int>[V];
        for( int i = 0; i < v; i++)
            adj[i] = new List<int>();
    }
    void AddEdge( int v, int w)
    {
        adj[v].Add(w);
    }

    void Dfs(int u, bool[] visited)
    {
        visited[u] = true;
        foreach (int v in adj[u])
            if (!visited[v])
                Dfs(v, visited);
    }
    static void Main()
    {
        Sc sc = new Sc();
        Graph g = new Graph(2005);
        var n = sc.I;
        int ini = 1;
        for( int i = 0; i < n; i++)
        {
            var p = sc.Ia;
            int u = p[0];
            int v = p[1];
            g.AddEdge(u, v);
            g.AddEdge(v, u);
        }
        bool[] vis = new bool[ini];
        g.Dfs(1, vis);
    }
}

public class Sc
{
    public int I { get { return int.Parse(Console.ReadLine()); } }
    public long L { get { return long.Parse(Console.ReadLine()); } }
    public double D { get { return double.Parse(Console.ReadLine()); } }
    public string S { get { return Console.ReadLine(); } }
    public int[] Ia { get { return Array.ConvertAll(Console.ReadLine().Split(), int.Parse); } }
    public long[] La { get { return Array.ConvertAll(Console.ReadLine().Split(), long.Parse); } }
    public double[] Da { get { return Array.ConvertAll(Console.ReadLine().Split(), double.Parse); } }
    public string[] Sa { get { return Console.ReadLine().Split(); } }
    public object[] Oa { get { return Console.ReadLine().Split(); } }
    public int[] Ia2 { get { return Array.ConvertAll(("0 " + Console.ReadLine() + " 0").Split(), int.Parse); } }
    public int[] Ia3(string a, string b)
    {
        return Array.ConvertAll((a + Console.ReadLine() + b).Split(), int.Parse);
    }
    public int[] Ia3(int a)
    {
        return Array.ConvertAll((Console.ReadLine() + " " + a.ToString()).Split(), int.Parse);
    }
    public long[] La2 { get { return Array.ConvertAll(("0 " + Console.ReadLine() + " 0").Split(), long.Parse); } }
    public long[] La3(string a, string b)
    {
        return Array.ConvertAll((a + Console.ReadLine() + b).Split(), long.Parse);
    }
    public long[] La3(int a)
    {
        return Array.ConvertAll((Console.ReadLine() + " " + a.ToString()).Split(), long.Parse);
    }
    public double[] Da2 { get { return Array.ConvertAll(("0 " + Console.ReadLine() + " 0").Split(), double.Parse); } }
    public double[] Da3(string a, string b)
    {
        return Array.ConvertAll((a + Console.ReadLine() + b).Split(), double.Parse);
    }
    public T[] Arr<T>(int n, Func<T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = f();
        }
        return a;
    }
    public T[] Arr<T>(int n, Func<int, T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = f(i);
        }
        return a;
    }
    public T[] Arr<T>(int n, Func<string[], T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = f(Console.ReadLine().Split());
        }
        return a;
    }
    public T[] Arr<T>(int n, Func<int, string[], T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = f(i, Console.ReadLine().Split());
        }
        return a;
    }
}
