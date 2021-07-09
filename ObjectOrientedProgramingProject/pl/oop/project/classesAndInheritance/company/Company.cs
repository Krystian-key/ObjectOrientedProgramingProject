/*using System;
using ObjectOrientedProgramingProject.pl.oop.project.classesAndInheritance.company.employee;
using ObjectOrientedProgramingProject.pl.oop.project.classesAndInheritance.company.skills;
using Action = ObjectOrientedProgramingProject.pl.oop.project.classesAndInheritance.company.skills.Action;

namespace ObjectOrientedProgramingProject.pl.oop.project.classesAndInheritance.company
{
    public class Company : ISkills
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.CompanyName = "Capgemini";
            company.CompanyType = "Cloud Services and Cybersecurity Consulting";
            company.CompanySize = 100000;

            Employee employee = new Employee();
            employee.CompanyName = "Capgemini";
            employee.CompanyType = "Cloud and Cybersecurity Services";
            employee.CompanySize = 10000;
            employee.CorpId = "K3c91d";
            employee.FirstName = "Grzegorz";
            employee.LastName = "Brzęszczykiewicz";
            employee.Skills = "Offensive Security and Cloud Security";
            employee.YearOfExperience = 8;
            employee.SalaryGross = 24000;
            employee.DetectedMalware("virus");
            employee.TakeAction("scan whole system");
            employee.IsBackUpEnabled(false);


            Console.WriteLine("");
            Console.WriteLine("Employee company Name = " + employee.CompanyName);
            Console.WriteLine("Employee Company Type = " + employee.CompanyType);
            Console.WriteLine("Employee Company Size = " + employee.CompanySize);
            Console.WriteLine("Employee CorpId = " + employee.CorpId);
            Console.WriteLine("Employee First Name = " + employee.FirstName);
            Console.WriteLine("Employee Last Name = " + employee.LastName);
            Console.WriteLine("Employee Skills = " + employee.Skills);
            Console.WriteLine("Employee Year Of Experience = " + employee.YearOfExperience);
            Console.WriteLine("Employee Salary Gross = " + employee.SalaryGross);
        }

        public string CompanyName { get; set; }

        public string CompanyType { get; set; }

        public long CompanySize { get; set; }

        public Company()
        {
        }

        public Company(string companyName, string companyType, long companySize)
        {
            CompanyName = CompanyName;
            CompanyType = CompanyType;
            CompanySize = CompanySize;
        }

        public Malware DetectedMalware(string malwareName)
        {
            Malware malware = new Malware();
            malware.MalwareName = "virus";
            return malware;
        }

        public Action TakeAction(string actionType)
        {
            Action action = new Action();
            action.ActionType = "scan whole system";
            return action;
        }

        public BackUp IsBackUpEnabled(bool isBackUpEnabled)
        {
            BackUp backUp = new BackUp();
            backUp.isBackUpEnabled = false;
            return backUp;
        }
    }
}*/