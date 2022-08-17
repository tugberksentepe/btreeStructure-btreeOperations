class Program
    {  
        
        //BTREE YAPISINA GİRİŞ

        class Block
        {
            public int data;
            public Block next;
            public Block prev;
        }

        static int[] binaryTree = new int[100]; 
        //0. elemanı Kök olur 
        //Kökün Solu 1. elemanıdır Sağı 2. elemanıdır.
        //2n+1 Parent in Solundaki Child i verir 2n+2 Sağındaki Child ı verir
        static void btreeYaz(int a)
        {
            if (a >= 10) return;
            Console.WriteLine(binaryTree[a]);
            btreeYaz(a * 2 + 1);
            //Console.WriteLine(binaryTree[a]); olsaydı kökün ilk en küçük child ını yazardı.
            btreeYaz(a * 2 + 2);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                binaryTree[i] = i+1;
            }
            btreeYaz(0);
        }
    }