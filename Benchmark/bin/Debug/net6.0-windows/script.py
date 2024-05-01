import subprocess
import sys
import matplotlib.pyplot as plt

def run_executable(executable, *args):
    command = [executable] + list(map(str, args))
    result = subprocess.run(command, stdout=subprocess.PIPE, text=True)
    return result.stdout.strip()

def run_and_plot(executable, num_runs, *args):
    speeds = []
    for i in range(1, num_runs + 1):
        output = run_executable(executable, *args)
        speed = float(output)  # Assuming the output is a float, adjust as needed
        speeds.append(speed)

    # Print average
    average_speed = sum(speeds) / num_runs
    if len(args) == 0:
        label = ""
    else:
        label = "Write" if args[0] == 1 else "Read"
    print(round(average_speed, 2))

    # Save the plot as a JPEG file with different filenames for RAM and Storage
    if "ram" in executable:
        filename = f"ram.jpg"
        plt.title('RAM Speeds')
        plt.ylabel('Speed GB/s')
    elif "storage" in executable:
        filename = f"storage.jpg"
        plt.title('Storage Speeds')
        plt.ylabel('Speed MB/s')
    else:
        filename = f"cpu.jpg"
        plt.title('CPU Frequency')
        plt.ylabel('Frequency GHz')
        label = "Frequency"

    plt.plot(range(1, num_runs + 1), speeds, marker='o', label=label)

    executable = executable[:-4]
    plt.xlabel('Run')
    plt.xticks(range(1, num_runs + 1))  # Set x-axis ticks to integers
    plt.legend()  # Add legend
    plt.savefig(filename)

def main(argument):
    if argument == "cpu":
        executable = "cpu.exe"
        run_and_plot(executable, 10)
    elif argument == "ram" or argument == "storage":
        executable = "ram.exe" if argument == "ram" else "storage.exe"
        for i in range(1, 3):  # Only one argument for RAM and Storage
            run_and_plot(executable, 10, i)
    else:
        print("Invalid argument. Please enter CPU, RAM, or Storage.")
        return

if __name__ == "__main__":
    if len(sys.argv) != 2:
        print("Usage: python3 script.py <argument>")
        sys.exit(1)

    argument = sys.argv[1].lower()
    main(argument)
