using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysisTask1.data;

namespace DataAnalysisTask1
{
    class DataAnalysis
    {
        public DataAnalysis() { }

        public void Analyse(List<int> AnalysisData_ID, ref Database dbPhone)
        {
            foreach (Phone phone in dbPhone.phones)
            {
                float analysis_Length = 0;

                if (AnalysisData_ID[0] != -1)
                    analysis_Length += (float)Math.Pow(
                        (dbPhone.batteries.Find(r => r.batteryID == AnalysisData_ID[0]).batteryCapacity - phone.battery.batteryCapacity)/100, 2);
                if (AnalysisData_ID[1] != -1)
                    analysis_Length += (float)Math.Pow(dbPhone.cpus.Find(r => r.cpuID == AnalysisData_ID[1]).cpuCore - phone.cpu.cpuCore, 2);
                if (AnalysisData_ID[2] != -1)
                    analysis_Length += (float)Math.Pow(dbPhone.cameras.Find(r => r.cameraID == AnalysisData_ID[2]).cameraMPX - phone.camera.cameraMPX, 2);
                if (AnalysisData_ID[3] != -1)
                    analysis_Length += (float)Math.Pow(dbPhone.memory.Find(r => r.memoryID == AnalysisData_ID[3]).memoryAmount - phone.memory.memoryAmount, 2);
                if (AnalysisData_ID[4] != -1)
                    analysis_Length += (float)Math.Pow(dbPhone.resoliutions.Find(r => r.resoliutionID == AnalysisData_ID[4]).resoliutionXaxis - phone.resoliution.resoliutionXaxis, 2);
                if (AnalysisData_ID[5] != -1)
                    analysis_Length += (float)Math.Pow(dbPhone.storages.Find(r => r.storageID == AnalysisData_ID[5]).storageCapacity - phone.storage.storageCapacity, 2);
                if (AnalysisData_ID[6] != -1)
                    analysis_Length += (float)Math.Pow(dbPhone.screens.Find(r => r.screenID == AnalysisData_ID[6]).Istrizaine() - phone.screen.Istrizaine(), 2);
                if (analysis_Length >= 0)
                    phone.AnalysisLength = (float)Math.Sqrt(analysis_Length);
            }
        }
    }
}
