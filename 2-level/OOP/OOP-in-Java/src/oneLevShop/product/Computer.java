package oneLevShop.product;

import java.math.BigDecimal;

import oneLevShop.AgeRestriction;

public class Computer extends ElectonicsProduct {
	private static final int COMPUTER_GUARANTEE_PERIOD = 24;
	private static final BigDecimal RETURNS_RATE = new BigDecimal("0.95");
	private static final int QUANTITY_DISCOUNT = 1000; 

	public Computer(String name, BigDecimal price, int quantity,
			AgeRestriction restriction) {
		super(name, price, quantity, restriction, COMPUTER_GUARANTEE_PERIOD);
	}
	
	@Override
	public BigDecimal getPrice() {
		if (this.quantity > QUANTITY_DISCOUNT) {
			return this.price.multiply(RETURNS_RATE);
		}
		
		return this.price;
	}
}
