package main

import (
	"fmt"
)

// Car struct defines a car with a make, model, fuel level, and mileage
type Car struct {
	Make     string
	Model    string
	Fuel     float64 // in liters
	Mileage  float64 // in kilometers
}

// NewCar is a constructor function for creating a new Car
func NewCar(make, model string, fuel, mileage float64) *Car {
	return &Car{
		Make:    make,
		Model:   model,
		Fuel:    fuel,
		Mileage: mileage,
	}
}

// StartEngine method prints a message indicating the car's engine has started
func (c *Car) StartEngine() {
	fmt.Printf("The engine of the %s %s has started.\n", c.Make, c.Model)
}

// Drive method drives the car a certain distance, consuming fuel
func (c *Car) Drive(distance float64) {
	const fuelConsumptionRate = 0.05 // 5 liters per 100 km
	requiredFuel := distance * fuelConsumptionRate

	if c.Fuel < requiredFuel {
		fmt.Println("Not enough fuel to drive the requested distance.")
		return
	}

	c.Mileage += distance
	c.Fuel -= requiredFuel
	fmt.Printf("Drove %.2f km. Remaining fuel: %.2f liters.\n", distance, c.Fuel)
}

// Refuel method refuels the car with a certain amount of fuel
func (c *Car) Refuel(amount float64) {
	c.Fuel += amount
	fmt.Printf("Refueled %.2f liters. Current fuel level: %.2f liters.\n", amount, c.Fuel)
}

// CheckFuelLevel method prints the current fuel level of the car
func (c *Car) CheckFuelLevel() {
	fmt.Printf("Current fuel level: %.2f liters.\n", c.Fuel)
}

func main() {
	// Create a new car
	myCar := NewCar("Toyota", "Corolla", 50.0, 10000.0)

	// Use the methods
	myCar.StartEngine()
	myCar.CheckFuelLevel()
	myCar.Drive(200)
	myCar.Refuel(20)
	myCar.Drive(100)
	myCar.CheckFuelLevel()
}
