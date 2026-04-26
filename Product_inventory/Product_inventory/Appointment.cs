class Appointment
{
    public Appointment(string patientName, string doctorName, DateTime appointmentDate)
    {
        PatientName = patientName;
        DoctorName = doctorName;
        AppointmentDate = appointmentDate;
        isReschedule = false;
    }

    public string PatientName { get; set; }
    public string DoctorName { get; set; }
    public DateTime AppointmentDate { get; set; }


    private bool isReschedule;

    public void Reschhedule(DateTime newDate)
    {
        AppointmentDate = newDate;
        isReschedule = true;
    }

    public void ShowDetail()
    {
        Console.WriteLine($"Appointment for {PatientName} with the doctor {DoctorName}");
        if(isReschedule)
        {
            Console.WriteLine($"New Date: {AppointmentDate.ToString("dd/MM/yyyy")}");
        }
        else
        {
            Console.WriteLine($"Date: {AppointmentDate.ToString("dd/MM/yyyy")}");
        }
    }

}