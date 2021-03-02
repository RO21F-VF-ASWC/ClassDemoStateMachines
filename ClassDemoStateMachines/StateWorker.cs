using System;
using ClassDemoStateMachines.StateDesignPattern;
using ClassDemoStateMachines.StateTable;

namespace ClassDemoStateMachines
{
    public class StateWorker
    {

        public void Start()
        {
            Console.Write("Indtast Tekst ");
            string str = Console.ReadLine();

            bool success = true;
            IStateMachine<char> sm = new StateMachineTable();


            foreach (char c in str)
            {
                if (!sm.NextInput(c))
                {
                    Console.WriteLine("Fejl i tekst streng er ikke (abc)* - var " + str);
                    success = false;
                    break;
                }
            }

            if (success)
            {
                Console.WriteLine("Tillykke strengen overholdt (abc)* ");
            }
        }
    }

}