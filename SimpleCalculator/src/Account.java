public class Account {
    private String accountNumber;
    private String ownerName;
    protected double balance;
    public Account(String accountNumber, String ownerName, double balance){
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        this.balance = balance;
    }
    public void deposit(double amount){
        if (amount > 0){
            balance += amount;
            System.out.println("Deposit: $" + amount);
        }else{
            System.out.println("Deposit amount is invalid!");
        }
    }
    public void withdraw(double amount){
        if(amount > 0 && amount <= balance){
            balance -=amount;
            System.out.println("withdraw: $"+ amount);
        }else{
            System.out.println("Invalid withdraw amount!");
        }
    }
    public void checkBalance(){
        System.out.println("Account Balance: $"+ balance);
    }
    public String getAccountNumber(){
        return accountNumber;
    }
}
