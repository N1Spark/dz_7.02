using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7._02
{
    public class Employet
    {
        private string FIO { get; set; }
        private string birthday { get; set; }
        private static int tel;
        private string email { get; set; }
        private string post { get; set; }
        private string post_descrip { get; set; }

        public Employet()
        {

        }
        public Employet(string f, string b, string e, string p, string p_d)
        {
            FIO = f;
            birthday = b;
            email = e;
            post = p;
            post_descrip = p_d;
        }
        static Employet()
        {
            Console.Write("Введите номер телефона: ");
            tel = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Full name: {FIO};\nBirthday: {birthday};\nTel: {tel};\nEmail: {email};\nPost: {post};\nPost description: {post_descrip}.");
        }
        public override string ToString()
        {
            return $"Full name: {FIO};\nBirthday: {birthday};\nTel: {tel};\nEmail: {email};\nPost: {post};\nPost description: {post_descrip}.";
        }
    }
}
