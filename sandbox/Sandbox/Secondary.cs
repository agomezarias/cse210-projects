using System;

class Secondary
{
    protected int _num;

    public Secondary(int num)
    {
        _num = num;
    }

    public int GetNum()
    {
        return _num;
    }

    public void SetNum(int num)
    {
        _num = num;
    }

    public void PauseShowCountdown(int num)
    {
        for (int i = num; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}