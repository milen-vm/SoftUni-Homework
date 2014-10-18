import java.math.BigDecimal;


public class Product implements Comparable<Product>{
	
	private String name;
	private BigDecimal price;
	
	public Product(String name, BigDecimal price) {
		super();
		this.name = name;
		this.price = price;
	}

	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public BigDecimal getPrice() {
		return price;
	}
	
	public void setPrice(BigDecimal price) {
		this.price = price;
	}
	public int compareTo(Product comparePrice) {
        
        BigDecimal otherPrice = ((Product) comparePrice).getPrice();

        //ascending order
        if(this.price.compareTo(otherPrice) == 1){
        	return 1;
        }
        else if(this.price == otherPrice){
        	     
        		return 0;
        	}
        return -1;
	}
}
