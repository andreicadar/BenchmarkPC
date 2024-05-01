#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>
#include <time.h>

#define DATA_SIZE (256 * 1024 * 1024) // 4 MB

double getWriteSpeed()
{
    clock_t start_time, end_time, duration1;

    int64_t* data = (long long*)malloc(DATA_SIZE * sizeof(long long));
    if (data == NULL)
    {
        perror("Memory allocation failed");
        return 1;
    }

    start_time = clock();

    for (int i = 0; i < DATA_SIZE; i++)
    {
    }

    end_time = clock();

    duration1 = (end_time-start_time);

    start_time = clock();

    for (int i = 0; i < DATA_SIZE; i++)
    {
        data[i] = 3;
    }

    end_time = clock();

    duration1 = (end_time-start_time) - duration1;
	double elapsed_time = (double)(duration1) / CLOCKS_PER_SEC;

    double write_speed = (double)DATA_SIZE * 8 / (elapsed_time*1024*1024*1024);
    printf("%.2f", write_speed);
    return write_speed;
}

double getReadSpeed()
{
    int64_t* data = (int64_t*)malloc(DATA_SIZE * sizeof(int64_t));
    if (data == NULL)
    {
        perror("Memory allocation failed");
        return 1;
    }

    clock_t start_time, end_time;

    for (int i = 0; i < DATA_SIZE; i++)
    {
        data[i] = 3;
    }
    unsigned long long x = 0;

    start_time = clock();
    for (int i = 0; i < DATA_SIZE; i++)
    {
        x+=2;
    }

    end_time = clock();

    clock_t duration1 = end_time - start_time;

    start_time = clock();
    for (int i = 0; i < DATA_SIZE; i++)
    {
        char value = data[i];
        x+=value;
    }
    end_time = clock();
    duration1 = (end_time-start_time) - (duration1);
	double elapsed_time = (double)(duration1) / CLOCKS_PER_SEC;

    double readSpeed = (double)DATA_SIZE * 8 / (elapsed_time*1024*1024*1024);
    printf("%.2f", readSpeed);

    return readSpeed;
}

int main(int argc, char *argv[])
{
    double theSpeed = 0;

    if(argv[1][0] == 49) // '1'
    {
        theSpeed = getWriteSpeed();
    }
    else
    {
        theSpeed = getReadSpeed();
    }

    FILE *file = fopen("outRAM.txt", "w");
    if (file != NULL)
    {
        fprintf(file, "%.2f", theSpeed);
        fclose(file);
    }
    else
    {
        perror("File open error");
        return 1;
    }
    return 0;
}
