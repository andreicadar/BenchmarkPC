import numpy as np
import matplotlib.pyplot as plt
from scipy.optimize import curve_fit

# Sample data
x_data = np.array([1, 2, 4, 8])
y_data = np.array([3.09, 4.24, 5.7, 6.5])

# Plot the data
plt.scatter(x_data, y_data, label='Data points')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.show()

# Define the logarithmic function
def log_function(x, a, b):
    return a * np.log(x) + b

# Perform the curve fit
params, covariance = curve_fit(log_function, x_data, y_data)

# Extract the parameters (a and b) from the result
a, b = params

# Print the parameters
print(f'a: {a}, b: {b}')

# Predict y for a new x
new_x = 4096*1024
predicted_y = log_function(new_x, a, b)
print(f'Predicted y for x={new_x}: {predicted_y}')
