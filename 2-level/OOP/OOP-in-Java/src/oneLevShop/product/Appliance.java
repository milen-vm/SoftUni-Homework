package oneLevShop.product;

import java.math.BigDecimal;

import oneLevShop.AgeRestriction;

public class Appliance extends ElectonicsProduct {
	private static final int APPLIANCE_GUARANTEE_PERIOD = 6;
	private static final BigDecimal RETURNS_RATE = new BigDecimal("1.05");
	private static final int QUANTITY_DISCOUNT = 50; 
	
	public Appliance(String name, BigDecimal price, int quantity,
			AgeRestriction restriction) {
		super(name, price, quantity, restriction, APPLIANCE_GUARANTEE_PERIOD);
	}

	@Override
	public BigDecimal getPrice() {
		if (this.quantity < QUANTITY_DISCOUNT) {
			return this.price.multiply(RETURNS_RATE);
		}
		
		return this.price;
	}
}
