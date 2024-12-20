public class CheckingAccount extends Account {
    private double overdraftLimit;

    public  CheckingAccount(String accountNumber, String ownerName, double balance, double overdraftLimit){
        super(accountNumber, ownerName, balance);
        this.overdraftLimit = overdraftLimit;
    }
    @Override
    public void withdraw(double amount){
        if(amount > 0 && (balance - amount >= -overdraftLimit)){
            balance -= amount;
            System.out.println("Withdraw: $"+ amount);
        }else{
            System.out.println("Overdraft limit exceeded!");
        }
    }
}
