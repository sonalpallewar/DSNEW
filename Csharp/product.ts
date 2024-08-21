// 1. Interface with Methods
interface Product {
  id: number;
  name: string;
  price: number;

  // Method to get product info
  getInfo(): string;
}

class Book implements Product {
  constructor(public id: number, public name: string, public price: number, public author: string) {}

  getInfo(): string {
    return `Book: ${this.name} by ${this.author}, priced at $${this.price}`;
  }
}

class Electronics implements Product {
  constructor(public id: number, public name: string, public price: number, public brand: string) {}

  getInfo(): string {
    return `Electronics: ${this.name} by ${this.brand}, priced at $${this.price}`;
  }
}

// 2. Type Alias and Union Types
type PaymentMethod = 'CreditCard' | 'PayPal' | 'Cash';

function processPayment(amount: number, method: PaymentMethod): void {
  console.log(`Processing payment of $${amount} using ${method}`);
}

// 3. Shopping Cart Example
class ShoppingCart {
  private items: Product[] = [];

  addItem(product: Product): void {
    this.items.push(product);
  }

  removeItem(productId: number): void {
    this.items = this.items.filter(item => item.id !== productId);
  }

  getTotal(): number {
    return this.items.reduce((total, item) => total + item.price, 0);
  }

  checkout(paymentMethod: PaymentMethod): void {
    const total = this.getTotal();
    console.log('Items in cart:');
    this.items.forEach(item => console.log(item.getInfo()));
    processPayment(total, paymentMethod);
  }
}

// 4. Usage Example
const cart = new ShoppingCart();

const book1 = new Book(1, "TypeScript Handbook", 29.99, "Anders Hejlsberg");
const laptop = new Electronics(2, "MacBook Pro", 1999.99, "Apple");

cart.addItem(book1);
cart.addItem(laptop);

cart.checkout('CreditCard'); // Processing payment of $2029.98 using CreditCard
