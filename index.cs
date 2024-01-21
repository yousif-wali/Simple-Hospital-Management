using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
    public class PatientMonitor
    {
        public int DeviceId { get; set; }
        public int PatientId { get; set; }
        public DateTime Timestamp { get; set; }
        public float Temperature { get; set; }
        public float HeartRate { get; set; }
        

        public PatientMonitor(int deviceId, int patientId, float temperature, float heartRate)
        {
            DeviceId = deviceId;
            PatientId = patientId;
            Timestamp = DateTime.Now;
            Temperature = temperature;
            HeartRate = heartRate;
        }

        public void DisplayVitalSigns()
        {
            Console.WriteLine($"[Device ID: {DeviceId}] Patient ID: {PatientId}, Time: {Timestamp}, Temperature: {Temperature}°C, Heart Rate: {HeartRate} bpm");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PatientMonitor monitor = new PatientMonitor(1234, 1, 37.0f, 80.0f);
            monitor.DisplayVitalSigns();
        }
    }
}
