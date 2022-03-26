using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string cmdType = cmdArgs[0];
                string cmdName = cmdArgs[1];

                if (cmdType == "register")
                {
                    string licensePlateNum = cmdArgs[2];

                    RegisterUser(parkingRegister, cmdName, licensePlateNum);
                }

                if (cmdType == "unregister")
                {
                    UnRegisterUser(parkingRegister, cmdName);
                }
            }

            foreach (var kvp in parkingRegister)
            {
                string userName = kvp.Key;
                string licensePlateNum = kvp.Value;

                Console.WriteLine($"{userName} => {licensePlateNum}");
            }
        }

        static void RegisterUser(Dictionary<string, string> parkingRegister , string userName , string licensePlateNum)
        {
            if (parkingRegister.ContainsKey(userName))
            {
                string licenseNumReg = parkingRegister[userName];
                Console.WriteLine($"ERROR: already registered with plate number {licenseNumReg}");
            }
            else
            {
                parkingRegister[userName] = licensePlateNum;
                Console.WriteLine($"{userName} registered {licensePlateNum} successfully");
            }
        }

        static void UnRegisterUser(Dictionary<string, string> parkingRegister, string userName)
        {
            if (!parkingRegister.ContainsKey(userName))
            {
                Console.WriteLine($"ERROR: user {userName} not found");
            }
            else
            {
                parkingRegister.Remove(userName);
                Console.WriteLine($"{userName} unregistered successfully");
            }
        }
    }
}
