import subprocess
import matplotlib.pyplot as plt

def run_executable(executable, *args):
    command = [executable] + list(map(str, args))
    result = subprocess.run(command, stdout=subprocess.PIPE, text=True)
    return result.stdout.strip()

def run_and_plot(executable, num_runs, *args):
    speeds = []
    for i in range(num_runs):
        output = run_executable(executable, *args)
        speed = float(output)  # Assuming the output is a float, adjust as needed
        speeds.append(speed)

    average_speed = sum(speeds) / num_runs
    return average_speed

def save_plot(executable, speeds, argument, index):
    filename = f"{argument}_{executable}_{index}.jpg"
    plt.plot(speeds, marker='o')
    plt.title(f'{argument} Speeds - {executable} {index}')
    plt.xlabel('Run')
    plt.ylabel('Speed')
    plt.savefig(filename)
    plt.close()

def main():
    argument = input("Enter CPU, RAM, or Storage: ").lower()

    if argument == "cpu":
        executable = "cpu.exe"
        speeds = [run_and_plot(executable, 5)]
        save_plot(executable, speeds, argument, 1)
    elif argument == "ram" or argument == "storage":
        executable = "ram.exe" if argument == "ram" else "storage.exe"
        speeds = []
        for i in range(1, 3):  # Arguments 1 and 2 for ram.exe and storage.exe
            average_speed = run_and_plot(executable, 5, i)
            speeds.append(average_speed)
            save_plot(executable, speeds, argument, i)
    else:
        print("Invalid argument. Please enter CPU, RAM, or Storage.")
        return

if __name__ == "__main__":
    main()
