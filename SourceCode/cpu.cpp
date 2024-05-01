#include <stdio.h>
#include <stdint.h>
#include <iostream>
#include <time.h>
#include <fstream>
#include <iomanip>

static __inline__ unsigned long long rdtsc(void)
{
    unsigned hi, lo;
    __asm__ __volatile__ ("rdtsc" : "=a"(lo), "=d"(hi));
    return ( (unsigned long long)lo)|( ((unsigned long long)hi)<<32 );
}


int main()
{
    std::ofstream fout("outCPU.txt");
    uint64_t start_cycles, end_cycles;
    clock_t start_time, end_time;

    start_cycles = rdtsc();
    start_time = clock();
    unsigned long long x = 0;
    for(unsigned long long i = 0; i <7500000000; i++)
    {
        if(i%2)
            x++;
        else
            x+=2;
    }

    end_cycles = rdtsc();
    end_time = clock();

    double elapsed_time = (double)(end_time - start_time) / CLOCKS_PER_SEC;

    // Calculate CPU frequency in Hz
    double cpu_frequency = (double)(end_cycles - start_cycles) / elapsed_time;

    // Print the measured CPU frequency
    //printf("Measured CPU Frequency: %lu Hz\n", (unsigned long)cpu_frequency);
    cpu_frequency/=1000; //KHz
    cpu_frequency/=1000; //MHz
    cpu_frequency/=1000; //GHz
    printf("%.2lf", cpu_frequency);
    fout << std::setprecision(3) << cpu_frequency;
    //printf("%llu", x);

    return 0;
}
