package oneLevShop.product;

import java.math.BigDecimal;

import oneLevShop.AgeRestriction;
import oneLevShop.interfaces.Buyable;

public abstract class Product implements Buyable {
	protected String name;
	protected BigDecimal price;
	protected int quantity;
	protected AgeRestriction restriction;
	
	public Product(String name, BigDecimal price, int quantity, AgeRestriction restriction) {
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.restriction = restriction;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		if (name.isEmpty() ||
				name == null ||
				name.length() < 2) {
			throw new IllegalArgumentException("Invalid product name!");
		}
		
		this.name = name;
	}

	@Override
	public abstract BigDecimal getPrice();

	public void setPrice(BigDecimal price) {
		if (price.compareTo(BigDecimal.ZERO) < 0) {
			throw new IllegalArgumentException("The price, must be positive!");
		}
		
		this.price = price;
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		if (quantity < 0) {
			throw new IllegalArgumentException("The quantity, must be positive!");
		}
		
		this.quantity = quantity;
	}

	public AgeRestriction getRestriction() {
		return restriction;
	}

	public void setRestriction(AgeRestriction restriction) {
		this.restriction = restriction;
	}
	
	@Override
	public String toString() {
		String str = "Name: " + this.name +
				"\nPrice: " + this.getPrice() +
				"\nQuantity: " + this.quantity +
				"\nAge Restriction: " + this.restriction;
		
		return str;
	}
}
