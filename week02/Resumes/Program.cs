using System;

class Program
{
    static void Main(string[] args)
    {
        Job firstJob = new Job();
        firstJob._company = "Progymedia";
        firstJob._jobTitle = "Full Stack Developer";
        firstJob._startYear = 2022;
        firstJob._endYear = 2024;

        Job secondJob = new Job();
        secondJob._company = "Prelib";
        secondJob._jobTitle = "Full Stack Developer";
        secondJob._startYear = 2024;
        secondJob._endYear = 2025;

        Resume resume = new Resume();
        resume._personName = "Luiz Credidio";
        resume._jobs.Add(firstJob);
        resume._jobs.Add(secondJob);
        resume.DisplayResume();
    }
}