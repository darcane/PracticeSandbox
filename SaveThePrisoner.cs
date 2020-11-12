namespace PracticeSandbox
{
    public class SaveThePrisoner
    {
        public static int WarnThePrisoner()
        {
            int n = 560644246 ;
            int m = 7879023 ;
            int s = 2;

            var shift = m % n;
            var p = (s + shift - 1) % n;
            return p == 0 ? n : p;
        }
    }
}