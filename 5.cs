using System;

interface Customer{
    string cust_name{ get; set; }
    int age{ get; set; }
}
class Bank{
    protected string bank_nm;
    protected string branch;
    
    public Bank(string bank_nm, string branch){
        this.bank_nm = bank_nm;
        this.branch = branch;
    }
    
    public void printBankInfo(){
        Console.WriteLine("Bank name: "+this.bank_nm);
        Console.WriteLine("Branch: "+this.branch);
    }
}
class Account : Bank,Customer{
    protected int acc_num;
    protected int bal;
    public string cust_name{ get; set; }
    public int age{ get; set; }
    
    public Account(string bank_nm, string branch, int acc_num, int bal) : base(bank_nm, branch){
        this.acc_num = acc_num;
        this.bal = bal;
    }
    public void printAccInfo(){
        base.printBankInfo();
        Console.WriteLine("Customer name: "+cust_name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Account num: "+this.acc_num);
        Console.WriteLine("Balance: "+this.bal);
    }
}
class HelloWorld {
  static void Main() {
    Account obj = new Account("BOI", "Ashok chowk", 123456, 12000);
    obj.cust_name = "abc";
    obj.age = 22;
    obj.printAccInfo();
    
  }
}
