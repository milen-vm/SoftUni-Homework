package oneLevShop;

import java.math.BigDecimal;

public class Customer {
	private String name;
	private int age;
	private BigDecimal balace;
	
	public Customer(String name, int age, BigDecimal balace) {
		super();
		this.setName(name);
		this.setAge(age);
		this.setBalace(balace);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		if (name.isEmpty() ||
				name == null ||
				name.length() < 2) {
			throw new IllegalArgumentException("Invalid customer name!");
		}
		
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		if (age <= 0 || age > 120) {
			throw new IllegalArgumentException("Age must be bigger than zero and smaller than 120!");
		}
		
		this.age = age;
	}

	public BigDecimal getBalace() {
		return balace;
	}

	public void setBalace(BigDecimal balace) {
		if (balace.compareTo(BigDecimal.ZERO) < 0) {
			throw new IllegalArgumentException("The balance must be positive!");
		}
		this.balace = balace;
	}
}
