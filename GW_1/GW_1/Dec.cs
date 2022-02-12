using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW_1
{
    public class Dec: IDec
    {
        int[] storge;//Массив
        int head;//Первый элемент
        int tail;//Последний элемент
        int realSize;//Возможный размер
        int size;//Размер массива

        public int Head
        {
            get{ return head; }
        }
        public int Tail
        {
            get{ return tail; }
        }
        public string toString()
        {
            string res = "";
            foreach (int val in storge)
            {
                res += Convert.ToString(val) + " ";
            }
            return res.TrimEnd();
        }

        public Dec()//По умолчанию
        {
            this.realSize = 10;
            this.size = 0;
            this.storge = new int[this.size];
            this.head = default;
            this.tail = default;

        }
        public Dec(int realSize)//С возможным размером
        {
            this.realSize = realSize;
            this.size = 0;
            this.storge = new int[this.size];
            this.head = default;
            this.tail = default;

        }
        public Dec(int[] input)//С входным массивом
        {
            this.size = input.Count();
            this.realSize = size * 2;
            this.head = input[0];
            this.tail = input[input.Count() - 1];
            this.storge = new int[input.Count()];
            Save(input);

        }
        private void Save(int[] input)//Переносит входной массив в храмиый
        {
            for (int i = 0; i < input.Count(); i++)
            {
                this.storge[i] = input[i];
            }
        }
        void CheakSize()//проверкаа возможного размера
        {
            if(this.size == this.realSize)
            {
                this.realSize = this.realSize * 2;
            }
        }
        public int AddLeft(int Ell)//добавления в начало
        {
            CheakSize();//проверяем размер
            this.size++;//+1 элемент
            int[] buf = new int[this.size];//временный массив
            buf[0] = Ell;//добовляем новый элемент
            for(int i = 1; i < this.size; i++)//дописываем существущие
            {
                buf[i] = this.storge[i - 1]; 
            }
            this.head = Ell;//обновляем голову
            this.storge = new int[size];//обновляем массив
            Save(buf);//сохроняем с новым элементом
            return Ell;
        }
        public int AddRight(int Ell)//по анологии
        {
            CheakSize();
            this.size++;
            int[] buf = new int[this.size];
            buf[size - 1] = Ell;
            for(int i = 0; i < this.size - 1; i++)
            {
                buf[i] = this.storge[i];
            }
            this.tail = Ell;
            this.storge = new int[size];
            Save(buf);
            return Ell;
        }
        public int DeletLeft()
        {
            int res = this.storge[0];
            this.size--;
            int[] buf = new int[this.size];
            for(int i = 0; i < size; i++)
            {
                buf[i] = this.storge[i + 1];
            }
            this.head = buf[0];
            this.storge = new int[size];
            Save(buf);
            return res;
        }
        public int DeletRight()
        {
            int res = this.storge[size - 1];
            this.size--;
            int[] buf = new int[this.size];
            for(int i = 0; i < this.size; i++)
            {
                buf[i] = this.storge[i];
            }
            this.tail = buf[size - 1];
            this.storge = new int[size];
            Save(buf);
            return res;
        }
    }
}
