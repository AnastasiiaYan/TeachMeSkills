namespace OOP_Task2;

public class Patient
{
    private string Name;
    private int TreatmentPlanСode;

    public Patient(string name, int treatmentPlanСode)
    {
        this.Name = name;
        this.TreatmentPlanСode = treatmentPlanСode;
    }
    
    public void AssignDoctor()
    {
        switch (TreatmentPlanСode)
        {
            case 1:
            Console.WriteLine($"Пациенту {Name} назначен хирург");
            new Surgeon().Treat();
            break;
            
            case 2:
            Console.WriteLine($"Пациенту {Name} назначен дантист");
            new Dentist().Treat();
            break;

            default:
            Console.WriteLine($"Пациенту {Name} назначен терапевт");
            new Therapist().Treat();
            break;
        } 
    }
}