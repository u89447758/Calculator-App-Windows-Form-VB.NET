# Simple Calculator Application

This is a simple calculator application built using Visual Basic (VB.NET). It provides basic arithmetic operations such as addition, subtraction, multiplication, and division. The application includes error handling to ensure a smooth user experience.

---

## Features

- **Basic Arithmetic Operations:**
  - Addition (`+`)
  - Subtraction (`-`)
  - Multiplication (`*`)
  - Division (`/`)

- **Error Handling:**
  - Prevents invalid inputs (e.g., non-numeric values).
  - Handles division by zero.
  - Detects undefined or overflow results.
  - Displays user-friendly error messages.

- **Decimal Support:**
  - Allows decimal point input.
  - Prevents multiple decimal points in a single number.

- **Clear Functionality:**
  - Resets the calculator to its initial state with a single button click.

---

## How to Use

1. **Entering Numbers:**
   - Click the number buttons (`0`-`9`) to input digits.
   - Use the decimal button (`.`) to add a decimal point to the number.

2. **Selecting an Operator:**
   - Click one of the operator buttons (`+`, `-`, `*`, `/`) to select the desired operation.

3. **Performing Calculations:**
   - After entering the second number, click the equals button (`=`) to compute the result.
   - The result will be displayed in the text box.

4. **Clearing the Calculator:**
   - Click the clear button (`C`) to reset the calculator and start a new operation.

---

## Error Handling

The calculator includes robust error handling to ensure smooth operation:
- **Invalid Inputs:** Displays an error message if the input is not a valid number.
- **Division by Zero:** Prevents division by zero and notifies the user.
- **Undefined Results:** Detects and handles cases where the result is undefined or too large (e.g., overflow).
- **Missing Operator:** Ensures an operator is selected before performing calculations.

---

## Code Structure

The application is structured as follows:
- **`Form1` Class:** Contains the main logic for the calculator.
  - **Variables:**
    - `firstNumber`: Stores the first number for the operation.
    - `currentOperator`: Stores the selected operator (`+`, `-`, `*`, `/`).
    - `isNewOperation`: Tracks whether a new operation is starting.
  - **Event Handlers:**
    - `NumberClick`: Handles number and decimal button clicks.
    - `OperatorClick`: Handles operator button clicks.
    - `btnEquals_Click`: Computes and displays the result.
    - `btnClear_Click`: Resets the calculator.

---

## Example Usage

1. **Addition:**
   - Enter `5`, click `+`, enter `3`, and click `=`. The result will be `8`.

2. **Division:**
   - Enter `10`, click `/`, enter `2`, and click `=`. The result will be `5`.

3. **Error Handling:**
   - Enter `10`, click `/`, enter `0`, and click `=`. The application will display an error message: "Cannot divide by zero!"

---

## Requirements

- **Development Environment:**
  - Visual Studio (recommended) or any IDE that supports VB.NET.
- **Framework:**
  - .NET Framework (version 4.0 or higher).

---

## How to Run

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Build and run the application.
4. Use the calculator interface to perform calculations.

---

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

---

Enjoy using the Simple Calculator Application!