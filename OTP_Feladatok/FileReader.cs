namespace OTP_Feladatok
{
    public class FileReader
    {
        internal static string Reader(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string value = sr.ReadToEnd(); // vágom, hogy felesleges ezzel helyet foglalni, de nem volt ötletem, hogy tudom returnolni, úgy, hogy még a streamet is lezárjam, soz
            sr.Close();
            return value; //sr.ReadToEnd();
        }
    }
}
