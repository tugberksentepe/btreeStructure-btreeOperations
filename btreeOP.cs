class Btree
    {
        public int data;
        public Btree right;
        public Btree left;
    }
    class Program
    {
        static int[] bTree = new int[100];
        static int SeaarchDizi(int data, int a)//dizi olduğunu varsayıyoruz
        {
            if (a >= bTree.Length) return 0;
            if (data == bTree[a]) return 1;
            return SeaarchDizi(data, a * 2 + 1) +
            SeaarchDizi(data, a * 2 + 2);
        }
        static int SearchList(int data, Btree b)//block olduğunu varsayıyoruz
        {
            if (b == null) return 0;
            if (data == b.data) return 1;
            return SearchList(data, b.left) +
            SearchList(data, b.right);
        }
        static int SearchListWhile(int data, Btree root)
        {
            if (root == null) return 0;
            if (root.data == data) return 1;
            Stack<Btree> st = new Stack<Btree>();
            if (root.left != null) st.Push(root.left);
            if (root.right != null) st.Push(root.right);
            while (st.Count > 0)
            {
                Btree temp = st.Pop();
                if (temp.data == data) return 1;
                if (temp.left != null) st.Push(temp.left);
                if (temp.right != null) st.Push(temp.right);


            }
            return 0;
        }

        static int SearchDiziSorted(int data, int a)
        {
            if (a >= bTree.Length) return 0;
            if (bTree[a] == data) return 1;
            if (data < bTree[a]) return SearchDiziSorted(data, a * 2 + 1);
            else return SearchDiziSorted(data, a * 2 + 2);
        }
        static int SearchSortedLinkedList(int data, Btree root)
        {
            if (root == null) return 0;
            if (root.data == data) return 1;
            if (data < root.data) return SearchSortedLinkedList(data, root.left);
            else return SearchSortedLinkedList(data, root.right);
        }
        static int SearchSortedLinkedListWhile(int data, Btree root)
        {
            if (root == null) return 0;
            while (root == null)
            {
                if (root.data == data) return 1;
                if (data < root.data)
                    root = root.left;
                else root = root.right;

            }
            return 0;
        }
        static void Tasima(int a, Btree root)//diziyi liste taşımak
        {
            if (a >= 100) return;
            if (root == null) return;
            root.data = bTree[a];
            if (a * 2 + 1 < 100) root.left = new Btree();
            if (a * 2 + 2 < 100) root.right = new Btree();
            Tasima(a * 2 + 1, root.left);
            Tasima(a * 2 + 2, root.right);
        }
        static void DiziSortedEkle(int data, int a)
        {
            if (a >= 100) return;
            if (bTree[a] == -1) { bTree[a] = data; return; }
            if (data < bTree[a])
                DiziSortedEkle(data, 2 * a + 1);
            else
                DiziSortedEkle(data, 2 * a + 2);


        }
        static Btree bt = null;
        static void DiziLinkedEkle(int data, Btree root)
        {
            //if (root == null) return;
            if (root == null)
            {
                root = new Btree();
                root.data = data; bt = root; return;

            }
            if (root.data < data)
            {
                if (root.right != null) { DiziLinkedEkle(data, root.right); }
                else { root.right = new Btree(); root.right.data = data; }
            }
            else
            {
                if (root.left != null) { DiziLinkedEkle(data, root.left); }
                else { root.left = new Btree(); root.left.data = data; }
            }
        }
        static void Main(string[] args)
        {


        }
    }