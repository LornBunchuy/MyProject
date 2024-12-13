public class SavingAccount extends Account {
    private double interestRate;
    public  SavingAccount(String accountNumber, String ownerName, double balance, double interestRate){
        super(accountNumber, ownerName, balance);
        this.interestRate = interestRate;
    }
    public void applyInterest(){
        double interest = balance * (interestRate / 100);
        balance += interest;
        System.out.println("Interest applied: $"+ interest);
    }
}
