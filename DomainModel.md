# classes


## IAccount
public List< IAccount> __accounts = new IAccount();
public List< Transactions> __transactions = new Transactions(); 

accounts.Add.Account(new savingsAccount);
accounts.Add.Account(new checkingsAccount);


## Savings Account : IAccounts

## Checking Account : IAccounts

## Transactions
private or protected  List< Transactions> transactions = new List< Transactions>();
	* DateTime.UTC.Now() -> When transaction is created

	private void __Withdraw();
	private void __Deposit();
	private void __Balance();
	
	public GetBalance 
	{
		return _Balance
	}

## User
 private Dictionary< string, IAccount> _userAccounts;
 public Dictionary< string, IAccount> UserAccounts => userAccounts;
	// generate unique Id
	public Guid Id {get; private set: } = Guid.Empty;
	create User
	private FullName = "firstName , lastName";
	public GetFullName();

	public GetAccounts() // list of existing accounts
 
