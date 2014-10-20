package oneLevShop.exceptions;

public class CustomerOutOfMoneyException extends ProductManagementException {
	private static final long serialVersionUID = 4L;
	
	public CustomerOutOfMoneyException(String mesage) {
		super(mesage);
	}

}
