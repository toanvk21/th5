using System;
using System.Runtime.Serialization;

namespace bai_5
{
    class Phong
    {
        protected int songaythue;
        private double dongia;
        public virtual void nhap()
        {
            Console.WriteLine("nhap so ngay thue"); songaythue = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap don gia/ngay"); dongia = double.Parse(Console.ReadLine());
        }
        public virtual double Tienphong()
        {
            return songaythue * dongia;
        }
        public virtual void hien()
        { 
            Console.WriteLine("so ngay thue" + songaythue);
            Console.WriteLine("don gia/ngay" + dongia);
            Console.WriteLine("doa don tra" + Tienphong());
        }
    }
    class A : Phong
    {
        public override void nhap()
        {
            base.nhap();
        }
        public override void hien()
        {
            Console.WriteLine("KHACH SAN PHONG LOAI : A");
            base.hien();        
        }
        public override double Tienphong()
        {
            if (songaythue > 5)
            {
                return base.Tienphong()-(base.Tienphong() * 0.1);
            }
            else return base.Tienphong();
        }
    }
    class B : Phong
    {
        public override void nhap()
        {
            base.nhap();
        }
        public override void hien()
        {
            Console.WriteLine("KHACH SAN PHONG LOAI : B");
            base.hien();
        }
        public override double Tienphong()
        {
            if (songaythue > 5)
            {
                return base.Tienphong() - (base.Tienphong() * 0.1);
            }
            else return base.Tienphong();
        }
    }
    class C : Phong
    {
        public override void nhap()
        {
            base.nhap();
        }
        public override void hien()
        {
            Console.WriteLine("KHACH SAN PHONG LOAI : C");
            base.hien();
        }
        public override double Tienphong()
        {
           
             return base.Tienphong();
        }
    }
    class QL
    {
        private Phong[] ds;
        private int sl;
        public void nhap()
        {
            Console.WriteLine("NHAP SL PHONG THUE");sl = int.Parse(Console.ReadLine());
            ds = new Phong[sl];
            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine("khach o phong 'A' hay 'B' hay 'C'?");
                char kt = char.Parse(Console.ReadLine());
                switch(char.ToUpper(kt))
                {
                    case 'A':ds[i] = new A();ds[i].nhap();break;
                    case 'B':ds[i] = new B(); ds[i].nhap(); break;
                    case 'C':ds[i] = new C(); ds[i].nhap(); break;

                }
            }
        }
        public void hien()
        {
            Console.WriteLine("thong tin tat ca cac phong");
            for (int i = 0; i < sl; i++)
            {
                ds[i].hien();
            }
        }
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            QL k = new QL();
            k.nhap();Console.Clear();
            k.hien();
            Console.ReadKey();
        }
    }
}
    
    
