package oneLevShop.exceptions;

public class CustomerOutOfPermissionException extends ProductManagementException {
	private static final long serialVersionUID = 5L;

	public CustomerOutOfPermissionException(String mesage) {
		super(mesage);
	}

}
