using System;

namespace CSharpCource
{
    class TheInverterOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("����������� ��������������� �������������� �������� 1267165676175383");
            long SecretID = 1267165676175383;
            string Binare64xSecretID = Convert.ToString(SecretID, 2).PadRight(64, '0');
            string BinareIdType = Binare64xSecretID.Substring(0, 2);
            string BinareIdCity = Binare64xSecretID.Substring(2, 15);
            string BinareIdTable = Binare64xSecretID.Substring(17, 15);
            string BinareIdObject = Binare64xSecretID.Substring(32, 32);
            int IdType = Convert.ToInt32(BinareIdType, 2);
            int IdCity = Convert.ToInt32(BinareIdCity, 2);
            int IdTable = Convert.ToInt32(BinareIdTable, 2);
            int IdObject = Convert.ToInt32(BinareIdObject, 2);
            Console.WriteLine("id ���� = " + IdType);
            Console.WriteLine("id ������ = " + IdCity);
            Console.WriteLine("id ������� = " + IdTable);
            Console.WriteLine("id ������� = " + IdObject);
            Console.ReadKey();
        }
    }
}
