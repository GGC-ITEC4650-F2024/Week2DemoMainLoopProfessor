public class Fruit {
    public String name;
    public double price;

    public Fruit(String n, double p){
        this.name = n;
        this.price = p;
    }

    public override string ToString()
    {
        return "This tasty " + name + " is only $" + price;
    }
}