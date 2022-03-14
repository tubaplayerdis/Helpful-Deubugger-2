using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace GoodLib
{
    public sealed class Class1
    {
        public int MyNumber { get; set; }
    }
    //Expose class
    public sealed class CPUInfo
    {
        public IList<char> ListOf { get; set; }
        ManagementObjectSearcher ManagementObjectSearcherv;
        public CPUInfo()
        {
            ManagementObjectSearcherv = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in ManagementObjectSearcherv.Get())
            {
                ListOf.Add($"Name  -  {obj["Name"]}".ToCharArray()[150]);
                ListOf.Add($"DeviceID  -  {obj["DeviceID"]}".ToCharArray()[150]);
                ListOf.Add($"Manufacturer  -  {obj["Manufacturer"]}".ToCharArray()[150]);
                ListOf.Add($"CurrentClockSpeed  -  {obj["CurrentClockSpeed"]}".ToCharArray()[150]);
                ListOf.Add($"Caption  -  {obj["Caption"]}".ToCharArray()[150]);
                ListOf.Add($"NumberOfCores  -  {obj["NumberOfCores"]}".ToCharArray()[150]);
                ListOf.Add($"NumberOfEnabledCores  -  {obj["NumberOfEnabledCore"]}".ToCharArray()[150]);
                ListOf.Add($"NumberOfLogicalProcessors  -  {obj["NumberOfLogicalProcessors"]}".ToCharArray()[150]);
                ListOf.Add($"Architecture  -  {obj["Architecture"]}".ToCharArray()[150]);
                ListOf.Add($"Family  -  {obj["Family"]}".ToCharArray()[150]);
                ListOf.Add($"ProcessorType  -  {obj["ProcessorType"]}".ToCharArray()[150]);
                ListOf.Add($"Characteristics  -  {obj["Characteristics"]}".ToCharArray()[150]);
                ListOf.Add($"AddressWidth  -  {obj["AddressWidth"]}".ToCharArray()[150]);
                //Should be 12 index from 0 - 12
            }
        }
    }
    
}
