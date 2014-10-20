package oneLevShop.product;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
import java.time.temporal.ChronoUnit;

import oneLevShop.AgeRestriction;
import oneLevShop.interfaces.Expirable;

public class FoodProduct extends Product implements Expirable {
	private static final BigDecimal RETURNS_RATE =  new BigDecimal("0.7");
	private static final int MIN_DAYS_TO_EXPIRATION = 15;
	private static final DateTimeFormatter DATE_FORMATTER = DateTimeFormatter.ofPattern("dd-MM-yyyy");
	
	private LocalDate expirationDate;
	private long daysToExpiration;
	
	public FoodProduct(String name, BigDecimal price, int quantity,
			AgeRestriction restriction, String expirationDateStr) {
		super(name, price, quantity, restriction);
		this.setExpirationDate(expirationDateStr);
		this.daysToExpiration = remainingDaysToExpiry();
	}
	
	@Override
	public LocalDate getExpirationDate() {
		return this.expirationDate;
	}

	public void setExpirationDate(String expirationDateStr) {
		try {			
			this.expirationDate = LocalDate.parse(expirationDateStr,DATE_FORMATTER);
		} catch (DateTimeParseException e) {
			throw new IllegalArgumentException(String.format(
					"Invalid expiration date!\nThe date must be in format \"%s\"!", DATE_FORMATTER));
		}
	}
	
	public long remainingDaysToExpiry() {
		long daysToExpiration = ChronoUnit.DAYS.between(LocalDate.now(), this.expirationDate);
		if (daysToExpiration < 0) {
			daysToExpiration = 0;
		}

		return daysToExpiration;
	}

	@Override
	public BigDecimal getPrice() {		
		if (this.daysToExpiration <= MIN_DAYS_TO_EXPIRATION) {
			return this.price.multiply(RETURNS_RATE);
		}
		
		return this.price;
	}
	
	public long getDaysToExpiration() {
		
		return daysToExpiration;
	}
	
	@Override
	public String toString(){
		String str = super.toString() + "\nExpiration date: " +
				this.expirationDate.format(DATE_FORMATTER);
		
		return str;
	}

}
