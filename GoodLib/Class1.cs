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
                ListOf.Add(Convert.ToChar($"Name  -  {obj["Name"]}"));
                ListOf.Add(Convert.ToChar($"Status  -  {obj["Status"]}"));
                ListOf.Add(Convert.ToChar($"Load Percentage  -  {obj["LoadPercentage"]}"));
                ListOf.Add(Convert.ToChar($"DeviceID  -  {obj["DeviceID"]}"));
                ListOf.Add(Convert.ToChar($"Manufacturer  -  {obj["Manufacturer"]}"));
                ListOf.Add(Convert.ToChar($"Current Clock Speed  -  {obj["CurrentClockSpeed"]}"));
                ListOf.Add(Convert.ToChar($"Caption  -  {obj["Caption"]}"));
                ListOf.Add(Convert.ToChar($"Number Of Cores  -  {obj["NumberOfCores"]}"));
                ListOf.Add(Convert.ToChar($"Number Of Enabled Cores  -  {obj["NumberOfEnabledCore"]}"));
                ListOf.Add(Convert.ToChar($"Number Of Logical Processors  -  {obj["NumberOfLogicalProcessors"]}"));
                ListOf.Add(Convert.ToChar($"Max Clock Speed  -  {obj["MaxClockSpeed"]}"));
                ListOf.Add(Convert.ToChar($"Architecture  -  {obj["Architecture"]}"));
                ListOf.Add(Convert.ToChar($"Family  -  {obj["Family"]}"));
                ListOf.Add(Convert.ToChar($"Processor Type  -  {obj["ProcessorType"]}"));
                ListOf.Add(Convert.ToChar($"Characteristics  -  {obj["Characteristics"]}"));
                ListOf.Add(Convert.ToChar($"Address Width  -  {obj["AddressWidth"]}"));
                //Should be 12 index from 0 - 15
                /*Indexs
                 * 0 - Name
                 * 1 - Status
                 * 2 - Load Percentage
                 * 3 - DeviceID
                 * 4 - Manufacturer
                 * 5 - Current Clock Speed
                 * 6 - Caption
                 * 7 - Number Of Cores
                 * 8 - Number Of Enabled Cores
                 * 9 - Number Of Logical Processors
                 * 10 - Max Clock Speed
                 * 11 - Architecture
                 * 12 - Family
                 * 13 - Processor Type
                 * 14 - Characteristics
                 * 15 - Address Width
                 */
            }
        }
    }
    
}
