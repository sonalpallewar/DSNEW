package main

import "fmt"

func main(){
	var x,y int
	fmt.Println("This program swaps two integers without using a temp variable.")
	fmt.Println("Enter integer x : ")
	fmt.Scanln(&x)
	fmt.Println("Enter integer y : ")
	fmt.Scanln(&y)
	fmt.Printf("x is %d, y is %d\n",x,y)
	swapInt(&x,&y) // change this to swapIntXor if you want to try out swaping via xor functions
	fmt.Printf("x is %d, y is %d\n",x,y)
	fmt.Println("This program swapped 2 integers")

}


//I'm using pointers just so that the pointers point to the correct integer after this function ends.
func swapInt(x *int, y *int){
	fmt.Println("Swapping x and y...")
	*x = *x + *y //x = x + y
	*y = *x - *y //y = x + y - y = x
	*x = *x - *y //x = x + y - x = y
}



//I'm using pointers just so that the pointers point to the correct integer after this function ends.
func swapIntNew(x *int, y *int){
	fmt.Println("Swapping x and y...")
	*x = *x + *y //x = x + y
	*y = *x - *y //y = x + y - y = x
	*x = *x - *y //x = x + y - x = y
	}

//A function that does the same thing but with the xor function.
func swapIntXor(x *int, y *int){
	fmt.Println("Swapping x and y with xor...")
	*x = *x^*y // x = x xor y
	*y = *x^*y //y = x xor y xor y = x
	*x = *x^*y // x = x xor y xor x = y
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

/*
I/O =>
This program swaps two integers without using a temp variable.
Enter integer x :
18
Enter integer y : 
-32
x is 18, y is -32
Swapping x and y...
x is -32, y is 18

Time complexity: O(1)
Space complexity: O(1)
*/