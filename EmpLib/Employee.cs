using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Employee : Person, IEmployeeContract
    {
        public event EventHandler Join;
        public event EventHandler Resign;
        //ctor
        //call base class constructo
        public Employee() : base()
        {
            this.ViewContract();
            this.Sign();
            this.EmpId = new Random(1000).Next();
            //access utility function
            EmpUtils.EmpCount++;
        }
        public void TriggerJoinEvent()
        {
            this.Join.Invoke(this, null);
        }
        public void TriggerResignEvent()
        {
            this.Resign.Invoke(this, null);
        }
        //call current class's other constructor
        public Employee(string pAadhar) : this()
        {
            this.Aadhar = pAadhar;
        }
        public Employee(string pAadhar, string pMobile) : base(pAadhar, pMobile)
        {
            this.ViewContract();
            this.Sign();
            this.EmpId = new Random(1000).Next();
            //access utility function
            EmpUtils.EmpCount++;
        }

        //variables inside a class are known as Fields
        private bool _contractSigned = false;
        private bool _hasReadContract = false;
        public void Sign()
        {
            _contractSigned = true;
        }

        public void ViewContract()
        {
            _hasReadContract = true;
        }
        private int _EmpId;
        public int EmpId { get { return _EmpId; } private set { _EmpId = value; } }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public bool IsActive { get; set; }
        public string AttendTraining(string pTraining)
        {
            return $"{this.Name} attended a training {pTraining}";
        }
        public string FillTimesheet(List<string> pTasks)
        {
            var csvTasks = "";
            foreach (var task in pTasks)
            {
                csvTasks = $"{csvTasks},{task} on {DateTime.Now.ToShortDateString()}";
            }
            return csvTasks;
        }
        public override string Work()
        {
            return $"{this.Name} with {this.EmpId} works for 8hrs a day at KPMG";
        }
        public string Work(string task)
        {
            return $"{this.Name} with {this.EmpId} has {task} assigned on {DateTime.Today}";
        }
        public void SetTaxInfo(string pTaxInfo)
        {
            this.TaxDetails = pTaxInfo;
        }
        public string GetTaxInfo()
        {
            return $"{this.Name}: Your tax details are: {this.TaxDetails}";
        }
        
    }
}



