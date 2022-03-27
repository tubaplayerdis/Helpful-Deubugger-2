using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Management.Infrastructure;


namespace GoodLib
{
    public sealed class Class1
    {
        public int MyNumber { get; set; }
    }
    //Expose class
    public sealed class CPUInfo
    {
        public IList<char[]> ListOf { get; set; } = new List<char[]>();
        CimInstance cimv;
        public CPUInfo()
        {            

        }

        public void Init()
        {
            try
            {
                CimSession cimSession = CimSession.Create("localhost");
                IEnumerable<CimInstance> queryInstances = cimSession.EnumerateInstances(@"root/cimv2", "Win32_Processor");  /*QueryInstances("", "", "select * from Win32_Processor")*/
                foreach (CimInstance obj in queryInstances)
                {
                    ListOf.Add($"Name  -  {obj.CimInstanceProperties["Name"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Status  -  {obj.CimInstanceProperties["Status"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Load Percentage  -  {obj.CimInstanceProperties["LoadPercentage"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"DeviceID  -  {obj.CimInstanceProperties["DeviceID"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Manufacturer  -  {obj.CimInstanceProperties["Manufacturer"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Current Clock Speed  -  {obj.CimInstanceProperties["CurrentClockSpeed"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Caption  -  {obj.CimInstanceProperties["Caption"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Number Of Cores  -  {obj.CimInstanceProperties["NumberOfCores"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Number Of Enabled Cores  -  {obj.CimInstanceProperties["NumberOfEnabledCore"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Number Of Logical Processors  -  {obj.CimInstanceProperties["NumberOfLogicalProcessors"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Max Clock Speed  -  {obj.CimInstanceProperties["MaxClockSpeed"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Architecture  -  {obj.CimInstanceProperties["Architecture"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Family  -  {obj.CimInstanceProperties["Family"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Processor Type  -  {obj.CimInstanceProperties["ProcessorType"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Characteristics  -  {obj.CimInstanceProperties["Characteristics"].Value.ToString()}".ToCharArray());
                    ListOf.Add($"Address Width  -  {obj.CimInstanceProperties["AddressWidth"].Value.ToString()}".ToCharArray());
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
            catch (Exception ex)
            {
                ListOf.Add(ex.Message.ToCharArray());
            }
        }
    }

}

