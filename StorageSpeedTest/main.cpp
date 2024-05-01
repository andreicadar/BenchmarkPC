#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>
#include <time.h>

#define DATA_SIZE (1024 * 1024 * 50) // 50 MB

double getStorageWriteSpeed()
{
    FILE *file = fopen("output.bin", "wb");
    if (file == NULL)
    {
        perror("File open error");
        return 1;
    }

    char *data = (char *)malloc(DATA_SIZE);
    if (data == NULL)
    {
        perror("Memory allocation failed");
        fclose(file);
        return 1;
    }

    clock_t start_time, end_time;

    start_time = clock();
    size_t bytes_written = fwrite(data, sizeof(char), DATA_SIZE, file);
    end_time = clock();

    fclose(file);
    free(data);

    if (bytes_written != DATA_SIZE)
    {
        perror("File write error");
        return 1;
    }

    clock_t duration = end_time - start_time;
    double write_speed = (double)DATA_SIZE / (duration) * CLOCKS_PER_SEC;

    return write_speed;
}

double getStorageReadSpeed()
{
    FILE *file = fopen("output.bin", "rb");
    if (file == NULL)
    {
        perror("File open error");
        return 1;
    }

    char *data = (char *)malloc(DATA_SIZE);
    if (data == NULL)
    {
        perror("Memory allocation failed");
        fclose(file);
        return 1;
    }

    clock_t start_time, end_time;

    start_time = clock();
    size_t bytes_read = fread(data, sizeof(char), DATA_SIZE, file);
    end_time = clock();

    fclose(file);
    free(data);

    if (bytes_read != DATA_SIZE)
    {
        perror("File read error");
        return 1;
    }

    clock_t duration = end_time - start_time;
    double read_speed = (double)DATA_SIZE / (duration) * CLOCKS_PER_SEC;
    //remove("output.bin");
    return read_speed;
}

int main(int argc, char *argv[])
{
    double theSpeed = 0;

    if (argc != 2)
    {
        printf("Usage: %s <1 for storage write, 2 for storage read>\n", argv[0]);
        return 1;
    }

    if (argv[1][0] == '1')
    {
        theSpeed = getStorageWriteSpeed();
    }
    else if (argv[1][0] == '2')
    {
        theSpeed = getStorageReadSpeed();
    }

    theSpeed /= 1024;
    theSpeed /= 1024;

    FILE *file = fopen("outStorage.txt", "w");
    if (file != NULL)
    {
        fprintf(file, "%.2f", theSpeed);
        printf("%.2f", theSpeed);
        fclose(file);
    }
    else
    {
        perror("File open error");
        return 1;
    }

    return 0;
}
