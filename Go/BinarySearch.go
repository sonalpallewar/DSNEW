package main

import (
	"fmt"
	"log"
	"os"
	"sort"
	"strconv"
)

// Implementation of binary search without using recursion
func search(array []int, elementToFind int) int {
	low := 0
	high := len(array) - 1

	for low <= high {
		// Find the middle index of array
		index := int((low + high) >> 1)

		// If find the element, return the position
		if array[index] == elementToFind {
			return index
		} else if array[index] < elementToFind {
			// The target value is on the upper portion of the array
			low = index + 1
		} else {
			// The target value is on the lower portion of the array
			high = index - 1
		}
	}

	// The searched item was not found
	return -1
}

// IsAdult method returns true if the person is 18 years or older
func (p *Person) IsAdult() bool {
	return p.Age >= 18
}
