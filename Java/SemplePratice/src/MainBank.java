import java.util.Scanner;
public class MainBank {
    public static void main(String[] args) {
//        // Create a savings account
//        SavingAccount savings = new SavingAccount("SA123", "Alice", 1000.0, 2.5);
//        savings.checkBalance();
//        savings.deposit(500);
//        savings.withdraw(300);
//        savings.applyInterest();
//        savings.checkBalance();
//
//        System.out.println();
//
//        // Create a checking account
//        CheckingAccount checking = new CheckingAccount("CA456", "Bob", 500.0, 200.0);
//        checking.checkBalance();
//        checking.withdraw(600); // Test overdraft
//        checking.withdraw(200); // Exceed overdraft limit
//        checking.checkBalance();
        Scanner scanner = new Scanner(System.in);

        // User input for creating a savings account
        System.out.println("Enter account number for savings account:");
        String savingsAccountNumber = scanner.nextLine();
        System.out.println("Enter owner name for savings account:");
        String savingsOwnerName = scanner.nextLine();
        System.out.println("Enter initial balance for savings account:");
        double savingsBalance = scanner.nextDouble();
        System.out.println("Enter interest rate for savings account:");
        double savingsInterestRate = scanner.nextDouble();
        scanner.nextLine();  // Consume the newline character

        // Create a savings account using user input
        SavingAccount savings = new SavingAccount(savingsAccountNumber, savingsOwnerName, savingsBalance, savingsInterestRate);
        savings.checkBalance();

        // User input for deposits, withdrawals, and applying interest
        System.out.println("Enter deposit amount for savings account:");
        double savingsDepositAmount = scanner.nextDouble();
        savings.deposit(savingsDepositAmount);

        System.out.println("Enter withdrawal amount for savings account:");
        double savingsWithdrawAmount = scanner.nextDouble();
        savings.withdraw(savingsWithdrawAmount);

        savings.applyInterest();
        savings.checkBalance();

        // Skip a line between account types
        System.out.println();

        // User input for creating a checking account
        System.out.println("Enter account number for checking account:");
        scanner.nextLine();  // Consume the newline character
        String checkingAccountNumber = scanner.nextLine();
        System.out.println("Enter owner name for checking account:");
        String checkingOwnerName = scanner.nextLine();
        System.out.println("Enter initial balance for checking account:");
        double checkingBalance = scanner.nextDouble();
        System.out.println("Enter overdraft limit for checking account:");
        double overdraftLimit = scanner.nextDouble();

        // Create a checking account using user input
        CheckingAccount checking = new CheckingAccount(checkingAccountNumber, checkingOwnerName, checkingBalance, overdraftLimit);
        checking.checkBalance();

        // User input for withdrawals in checking account
        System.out.println("Enter withdrawal amount for checking account:");
        double checkingWithdrawAmount = scanner.nextDouble();
        checking.withdraw(checkingWithdrawAmount);

        checking.checkBalance();

        // Close scanner to prevent resource leak
        scanner.close();
    }
}
