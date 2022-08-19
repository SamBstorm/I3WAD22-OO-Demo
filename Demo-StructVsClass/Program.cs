using System;

namespace Demo_StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartphoneStruct smartS = default; //Obtient une instance de la structure

            SmartphoneClass smartC = default; //Obtient null par default

            smartS = new SmartphoneStruct(); //a l'aide d'un new on obtient bien une instance
            smartC = new SmartphoneClass(); //a l'aide d'un new on obtient bien une instance

            Console.WriteLine($"struct : {smartS}");
            Console.WriteLine($"class : {smartC}");

            //une nouvelle instance de class, comme de struct, donne les valeurs par défaut aux champs.

            smartS.marque = "Motorola";
            smartS.modele = "G9 PLus";
            smartS.serialNumber = "1234567890";
            smartS.pixelHeight = 1280;
            smartS.pixelWidth = 640;

            smartC.marque = "Samsung";
            smartC.modele = "Galaxy S20";
            smartC.serialNumber = "0987654321";
            smartC.pixelHeight = 2960;
            smartC.pixelWidth = 1440;

            SmartphoneClass smartMaya = new SmartphoneClass();
            smartMaya.marque = smartC.marque;
            smartMaya.modele = smartC.modele;
            smartMaya.serialNumber = smartC.serialNumber;
            smartMaya.pixelHeight = smartC.pixelHeight;
            smartMaya.pixelWidth = smartC.pixelWidth;

            SmartphoneClass smartAllessandra = new SmartphoneClass();
            smartAllessandra.marque = smartC.marque;
            smartAllessandra.modele = smartC.modele;
            smartAllessandra.pixelHeight = smartC.pixelHeight;
            smartAllessandra.pixelWidth = smartC.pixelWidth;
            smartAllessandra.serialNumber = "abcdefghij";

            Console.WriteLine($"smartMaya : {smartMaya.serialNumber} - smartAllessandra : {smartAllessandra.serialNumber}");
        }
    }
}
