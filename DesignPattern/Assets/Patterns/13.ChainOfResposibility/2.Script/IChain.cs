using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class ICalculator
{
    ICalculator nextCalculator;
    public void SetCalculator(ICalculator calculator)
    {
        nextCalculator = calculator;
    }
    public void AddProcess(ICalculator process)
    {
        if (nextCalculator == null)
            SetCalculator(process);
        else
            nextCalculator.AddProcess(process);
    }
    public bool Process(Request re)
    {
        if (Operator(re))        
            return true;
        else
        {
            if (nextCalculator == null) return false;
            return nextCalculator.Process(re);
        }
    }
    abstract protected bool Operator(Request re);
}
public class PlusCalculator : ICalculator
{
    protected override bool Operator(Request re)
    {
        if (re.Op.Equals("+"))
        {
            Debug.Log(re.A + re.B);
            return true;
        }
        return false;

    }
}
public class SubCalculator : ICalculator
{
    protected override bool Operator(Request re)
    {
        if (re.Op.Equals("-"))
        {
            Debug.Log(re.A - re.B);
            return true;
        }
        return false;

    }
}
public class MutiCalculator : ICalculator
{
    protected override bool Operator(Request re)
    {
        if (re.Op.Equals("*"))
        {
            Debug.Log(re.A * re.B);
            return true;
        }
        return false;

    }
}

public class DisCalculator : ICalculator
{
    protected override bool Operator(Request re)
    {
        if (re.Op.Equals("/"))
        {
            Debug.Log(re.A / re.B);
            return true;
        }
        return false;

    }
}

public class Request
{
    int a, b;
    string op;

    public Request(int a, int b, string op)
    {
        this.a = a;
        this.b = b;
        this.op = op;
    }

    public int A
    {
        get
        {
            return a;
        }

        set
        {
            a = value;
        }
    }

    public int B
    {
        get
        {
            return b;
        }

        set
        {
            b = value;
        }
    }

    public string Op
    {
        get
        {
            return op;
        }

        set
        {
            op = value;
        }
    }
}