package main

import (
	"fmt"
)

// Person struct defines a person with a name and age
type Person struct {
	Name string
	Age  int
}

// NewPerson is a constructor function for creating a new Person
func NewPerson(name string, age int) *Person {
	return &Person{
		Name: name,
		Age:  age,
	}
}

// Greet method prints a greeting message for the person
func (p *Person) Greet() {
	fmt.Printf("Hello, my name is %s and I am %d years old.\n", p.Name, p.Age)
}

// HaveBirthday method increases the person's age by 1
func (p *Person) HaveBirthday() {
	p.Age++
	fmt.Printf("Happy birthday %s! You are now %d years old.\n", p.Name, p.Age)
}

// ChangeName method changes the person's name
func (p *Person) ChangeName(newName string) {
	p.Name = newName
	fmt.Printf("My new name is %s.\n", p.Name)
}

func main() {
	// Create a new person
	person := NewPerson("Alice", 30)

	// Use the methods
	person.Greet()
	person.HaveBirthday()
	person.ChangeName("Alice Smith")
	person.Greet()
}
