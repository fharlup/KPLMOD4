using System;

class DoorMachine
{
    static void Main(string[] args)
    {
        Door door = new Door();
        door.Close();
        door.Lock();
        door.Unlock();
        door.Open();
    }
}

class Door
{
    private bool isOpen;
    private bool isLocked;

    public Door()
    {
        isOpen = false;
        isLocked = false;
    }

    public void Open()
    {
        if (!isLocked)
        {
            isOpen = true;
            Console.WriteLine("The door is now open.");
        }
        else
        {
            Console.WriteLine("The door is locked. Unlock it first.");
        }
    }

    public void Close()
    {
        isOpen = false;
        Console.WriteLine("The door is now closed.");
    }

    public void Lock()
    {
        isLocked = true;
        Console.WriteLine("The door is now locked.");
    }

    public void Unlock()
    {
        isLocked = false;
        Console.WriteLine("The door is now unlocked.");
    }
}
