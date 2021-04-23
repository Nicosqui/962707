using System;

namespace university_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector financiero";
            vicFinPosition.Salary = 750;
            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe financiero";
            jefeFinPosition.Salary = 610;
            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;
            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;


            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector academico";
            vicAcadPosition.Salary = 780;
            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de registro";
            jefeRegPosition.Salary = 640;
            Position sectReg2Position = new Position();
            sectReg2Position.Name = "Secretaria de registro 2";
            sectReg2Position.Salary = 360;
            Position sectReg1Position = new Position();
            sectReg1Position.Name = "Secretaria de registro 1";
            sectReg1Position.Salary = 400;
            Position asist2Position = new Position();
            asist2Position.Name = "Asistente 2";
            asist2Position.Salary = 170;
            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;
            Position asist1Position = new Position();
            asist1Position.Name = "Asistente 1";
            asist1Position.Salary = 250;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, sectReg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, sectReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, sectReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);

            universityTree.CreatePosition(universityTree.Root, asist1Position, sectReg1Position.Name);

            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries : {totalSalary}");

            Console.ReadLine();
        }
    }
}
