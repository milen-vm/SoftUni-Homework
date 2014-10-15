using System;
using System.Collections.Generic;
using System.Linq;

class PCCatalog
{
    static void Main()
    {
        Component cpu1 = new Component("CPU", 72.20m, "Intel Celeron G1820 /2.7G/2MB/BOX s.1150");
        Component motherboard1 = new Component("MB", 129.30m, "ASUS H81I-PLUS/H81/ s.1150");
        Component videoCard1 = new Component("VC", 62.80m, "Palit GF210 PCI-E 1GB LP DDR3 HDMI");
        Component hardDrive1 = new Component("HDD", 77.60m, "WD 320GB 7200/SATA2/8MB");
        Component memory1 = new Component("RAM", 84.60m, "GeIL DDR3 4GB/1600MHz/Bulk");
        Component chassis1 = new Component("CASE", 66.00m, "TrendSonic SI12A Shield Black 600W-120mm");

        List<Component> components1 = new List<Component>() { cpu1, motherboard1, videoCard1, hardDrive1, memory1, chassis1 };

        Computer computerOne = new Computer(components1);

        Component cpu2 = new Component("CPU", 77.40m, "AMD A4 X2 6300 /3.7G/1MB/BOX s.FM2");
        Component motherboard2 = new Component("MB", 91.40m, "Asrock FM2A55M-HD+/A55/ s.FM2");
        Component hardDrive2 = new Component("HDD", 109.30m, "WD Caviar Green 1TB 7200/SATA3/64MB");
        Component memory2 = new Component("RAM", 89.40m, "Kingston DDR3 4GB/1600MHz/HyperX CL10");
        Component chassis2 = new Component("CASE", 72.80m, "CM Elite 361 Black w/o PSU");
        Component powerSuplay2 = new Component("PWR", 103.80m, "Corsair CP-9020046-EU 430W-120mm");

        List<Component> components2 = new List<Component>() { cpu2, motherboard2, hardDrive2, memory2, chassis2, powerSuplay2 };

        Computer computerTwo = new Computer(components2);

        Component cpu3 = new Component("CPU", 100.10m, "AMD Athlon X4 5150 /1.6G/2MB/BOX s.AM1");
        Component motherboard3 = new Component("MB", 78.30m, "Asrock AM1B-ITX / s.AM1");
        Component hardDrive3 = new Component("HDD", 111.70m, "TOSHIBA 1TB 7200/SATA3/32MB");
        Component memory3 = new Component("RAM", 66.50m, "Kingston DDR3 2GB/1333MHz CL9");
        Component chassis3 = new Component("CASE", 62.00m, "Delux DLC-MV875 300W-REAL-120mm");

        List<Component> components3 = new List<Component>() { cpu3, motherboard3, hardDrive3, memory3, chassis3 };

        Computer computerThree = new Computer(components3);

        List<Computer> computers = new List<Computer>() { computerOne, computerTwo, computerThree };

        //foreach (Computer computer in computers)
        //{
        //    computer.PrintComputerComponents();
        //}

        computers = computers.OrderBy(computer => computer.Price).ToList();

        foreach (Computer computer in computers)
        {
            computer.PrintComputerComponents();
        }
    }
}
