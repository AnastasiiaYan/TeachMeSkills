namespace OOP_Task2;

public class Patient
{
    private string name;
    private int TreatmentPlanСode;

    public Patient(string name, int treatmentPlanСode)
    {
        this.name = name;
        this.TreatmentPlanСode = treatmentPlanСode;
    }
    
    public void AssignDoctor()
    {
        switch (TreatmentPlanСode)
        {
            case 1:
            Console.WriteLine($"Пациенту {name} назначен хирург");
            new Surgeon().Treat();
            break;
            
            case 2:
            Console.WriteLine($"Пациенту {name} назначен дантист");
            new Dentist().Treat();
            break;

            default:
            Console.WriteLine($"Пациенту {name} назначен терапевт");
            new Therapist().Treat();
            break;
        } 
    }
}