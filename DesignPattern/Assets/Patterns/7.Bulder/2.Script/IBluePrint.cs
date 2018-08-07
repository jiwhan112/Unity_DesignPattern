using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IBuilder_BluePrint
{
    // 최종객체를 만들기위해 어떤 부품이 필요한가. 선언
    // 단계를 나눈다.
    void SetCPU();
    void SetRAM();
    void SetVGA();

}
public class Computer : IBuilder_BluePrint
{
    private string cpu;
    private string ram;
    private string vga;

    public Computer()
    {
        Cpu = "Default";
        Ram = "Default";
        Vga = "Default";
    }

    public string Cpu
    {
        get
        {
            return cpu;
        }

        set
        {
            cpu = value;
        }
    }

    public string Ram
    {
        get
        {
            return ram;
        }

        set
        {
            ram = value;
        }
    }

    public string Vga
    {
        get
        {
            return vga;
        }

        set
        {
            vga = value;
        }
    }

    /// <summary>
    ///  세부 구현은 세부 클래스에서 실행
    /// </summary>
    public virtual void SetCPU()
    {
    }

    public virtual void SetRAM()
    {
    }

    public virtual void SetVGA()
    {
    }

    public override string ToString()
    {
        return "CPU:" + cpu + "\nRAM:" + ram + "\nVGA:" + vga;
    }
}

public class ComputerFactory // 설계도를 넣어주면 만드는 Factory 클래스생성
{
    Computer computer; //생성될 최종 객체
    public Computer Get()
    {
        return computer;
    }   
  
    public void Make(Computer p) 
    {
        computer = p;
        computer.SetCPU();
        computer.SetRAM();
        computer.SetVGA();
    }
}

public class ComputerBuilder
{
    Computer Com;

    public ComputerBuilder()
    {
        Com = new Computer();
    }

    public static ComputerBuilder Start()
    {
        return new ComputerBuilder();
    }
    public ComputerBuilder SetCPU(string s)
    {
        Com.Cpu = s;
        return this;
    }
    public ComputerBuilder SetRAM(string s)
    {
        Com.Ram = s;
        return this;
    }
    public ComputerBuilder SetVGA(string s)
    {
        Com.Vga = s;
        return this;
    }
    public Computer Build()
    {
        return this.Com;
    }


}

public class LGComputer : Computer // 최종객체를 상속받고 각자 세부클래스에서 구현
{
    public override void SetCPU()
    {
        Cpu = "i7";
      
    }

    public override void SetRAM()
    {
        Ram = "16g";
    }

    public override void SetVGA()
    {
        Vga = "1080GTA";
    }
}
public class MacComputer : Computer
{
    public override void SetCPU()
    {
        Cpu = "i5";

    }

    public override void SetRAM()
    {
        Ram = "4g";
    }

    public override void SetVGA()
    {
        Vga = "980GTA";
    }
}




