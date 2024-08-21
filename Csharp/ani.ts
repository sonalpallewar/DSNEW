// TypeScript Example Code

// 1. Basic Types
let isDone: boolean = false;
let age: number = 30;
let userName: string = "Alice";

// 2. Arrays
let numberArray: number[] = [1, 2, 3, 4, 5];
let stringArray: Array<string> = ["apple", "banana", "cherry"];

// 3. Tuples
let tuple: [string, number];
tuple = ["John", 25];

// 4. Enums
enum Color {
  Red,
  Green,
  Blue,
}
let color: Color = Color.Green;

// 5. Interfaces
interface Person {
  firstName: string;
  lastName: string;
  age?: number; // Optional property
}

function greet(person: Person): string {
  return `Hello, ${person.firstName} ${person.lastName}!`;
}

let user: Person = { firstName: "Jane", lastName: "Doe" };
console.log(greet(user)); // Output: Hello, Jane Doe!

// 6. Classes and Inheritance
class Animal {
  constructor(public name: string) {}

  move(distanceInMeters: number = 0): void {
    console.log(`${this.name} moved ${distanceInMeters} meters.`);
  }
}

class Dog extends Animal {
  bark(): void {
    console.log("Woof! Woof!");
  }
}

let dog = new Dog("Rex");
dog.bark(); // Output: Woof! Woof!
dog.move(10); // Output: Rex moved 10 meters.

// 7. Generics
function identity<T>(arg: T): T {
  return arg;
}

let output = identity<string>("TypeScript");
console.log(output); // Output: TypeScript

// 8. Type Assertions
let someValue: unknown = "This is a string";
let strLength: number = (someValue as string).length;

console.log(strLength); // Output: 16
