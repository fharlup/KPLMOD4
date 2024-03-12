using System;

class DoorMachine
{
    public enum StatePintu
    {
        Terkunci, Terbuka
    };

    public enum Triger
    {
        KunciPintu, BukaPintu
    }

    public class Transition
    {
        public StatePintu stateAwal;
        public StatePintu stateAkhir;
        public Triger triger;

        public Transition(StatePintu stateAwal, StatePintu stateAkhir, Triger triger)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.triger = triger;
        }
    }

    Transition[] transitions = {
        new Transition(StatePintu.Terkunci, StatePintu.Terbuka, Triger.BukaPintu),
        new Transition(StatePintu.Terbuka, StatePintu.Terkunci, Triger.KunciPintu)
    };

    public StatePintu curentState = StatePintu.Terkunci;

    public StatePintu GetNextState(StatePintu stateAwal, Triger triger)
    {
        StatePintu stateAkhir = stateAwal;
        for (int i = 0; i < transitions.Length; i++)
        {
            Transition perubahan = transitions[i];
            if (stateAwal == perubahan.stateAwal && triger == perubahan.triger)
            {
                stateAkhir = perubahan.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public void ActivateTriger(Triger triger)
    {
        curentState = GetNextState(curentState, triger);
        Console.WriteLine("pintu sekarang " + curentState);
    }
}

class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();
        Console.WriteLine("pintu sekarang " + pintu.curentState);
        pintu.ActivateTriger(DoorMachine.Triger.BukaPintu);
        pintu.ActivateTriger(DoorMachine.Triger.KunciPintu); 
    }
}
