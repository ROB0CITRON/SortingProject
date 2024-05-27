using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class Vizualizace : Form
    {
        #region Var
        static Rectangle[] rectangles;
        static Vizualizace okno;
        int[] numbers;
        static int pocet = 20;
        static int delay = 100;
        static int algoritmus;
        static bool fMode;
        static int zapisy;
        static int porovnani;
        static double cas;
        static Label lbCas;
        static Label lbZapis;
        static Label lbPorovnani;
        static Stopwatch stopwatch;
        static bool start = false;
        static bool algChosen = false;
        static bool close = false;
        static bool delBool = false;
        int picInt = 0;
        #endregion

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Vizualizace(int pPrvku, int dDelay, int alg, bool fast)
        {
            InitializeComponent();
            okno = this;
            pocet = pPrvku;
            delay = dDelay;
            algoritmus = alg;
            fMode = fast;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

        }

        private void Vizualizace_Load(object sender, EventArgs e)
        {
            resetForm();

            start = false;
            algChosen = false;
            close = false;
            okno = this;
            trbr_speed.Value = delay;

            rectangles = new Rectangle[pocet];
            GenPole();
            //1030 -> 930 šířka jen,  50 margin
            // Generování a ukládání obdélníků do pole
            int startX = 50;
            int startY = 489 - 10;
            int width = (930) / pocet;
            if (width < 1)
            {
                width = 1;
                okno.Width = pocet + 100;
            }
            for (int i = 0; i < pocet; i++)
            {
                rectangles[i] = new Rectangle(startX + i * (width), startY - Map(numbers[i], pocet, 360), width, Map(numbers[i], pocet, 360));
            }

            lb_prvky.Text = "Number of elements: " + pocet;
            lbCas = lb_cas;
            lbPorovnani = lb_porovnani;
            lbZapis = lb_zapisu;

            zapisy = 0;
            porovnani = 0;
            cas = 0;

            switch (algoritmus)
            {
                case 1:
                    this.Text = "Bubble Sort";
                    break;
                case 2:
                    this.Text = "Odd-Even Sort";
                    break;
                case 3:
                    this.Text = "Quick Sort";
                    break;
                case 4:
                    this.Text = "Bogo Sort";
                    break;
                case 5:
                    this.Text = "Heap Sort";
                    break;
                case 6:
                    this.Text = "Merge Sort";
                    break;
                default:
                    break;
            }
        }

        void BubbleSortAlgorithm(int[] arr, int pocet)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        if (close)
                        {
                            return;
                        }
                    }
                    porovnani++;

                    if (!fMode)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lbPorovnani.Text = "Number of comparisons: " + porovnani;

                            cas = stopwatch.Elapsed.TotalMilliseconds;
                            lbCas.Text = "Elapsed time: " + cas + " ms";
                        });
                    }
                }
                if (fMode)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        okno.Refresh();
                        lbPorovnani.Text = "Number of comparisons: " + porovnani;

                        cas = stopwatch.Elapsed.TotalMilliseconds;
                        lbCas.Text = "Elapsed time: " + cas + " ms";
                    });
                }
            }
        }




        void OddEvenSortAlgorithm(int[] arr, int pocet)
        {
            int n = arr.Length;
            bool sorted = false; // Zjistí, zda je pole již seřazené

            while (!sorted)
            {
                sorted = true;

                // Provádí se dvě fáze: lichá a sudá
                for (int i = 1; i < n - 1; i += 2) // Lichá fáze
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        sorted = false;
                        if (close)
                        {
                            return;
                        }
                    }
                    porovnani++;

                    if (!fMode)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lbPorovnani.Text = "Number of comparisons: " + porovnani;

                            cas = stopwatch.Elapsed.TotalMilliseconds;
                            lbCas.Text = "Elapsed time: " + cas + " ms";
                        });
                    }
                }

                for (int i = 0; i < n - 1; i += 2) // Sudá fáze
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        sorted = false;
                        if (close)
                        {
                            return;
                        }
                    }
                    porovnani++;

                    if (!fMode)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lbPorovnani.Text = "Number of comparisons: " + porovnani;

                            cas = stopwatch.Elapsed.TotalMilliseconds;
                            lbCas.Text = "Elapsed time: " + cas + " ms";
                        });
                    }
                }
                if (fMode)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        okno.Refresh();
                        lbPorovnani.Text = "Number of comparisons: " + porovnani;

                        cas = stopwatch.Elapsed.TotalMilliseconds;
                        lbCas.Text = "Elapsed time: " + cas + " ms";
                    });
                }
            }
        }


        private void Quick_Sort(int[] arr, int left, int right)
        {
            // Check if there are elements to sort
            if (left < right)
            {
                if (close)
                {
                    return;
                }
                // Find the pivot index
                int pivot = Partition(arr, left, right);

                // Recursively sort elements on the left and right of the pivot
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
                if (close)
                {
                    return;
                }
            }
        }

        // Method to partition the array
        int Partition(int[] arr, int left, int right)
        {
            // Select the pivot element
            int pivot = arr[left];

            Color col = Color.Blue;
            if (fMode)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    okno.Refresh();
                });

            }
            // Continue until left and right pointers meet
            while (true)
            {
                if (close)
                {
                    return 0;
                }
                using (SolidBrush brush = new SolidBrush(col))
                {
                    using (Graphics g = okno.CreateGraphics())
                    {
                        try
                        {
                            g.FillRectangle(brush, rectangles[pivot]);
                        }
                        catch
                        {

                        }
                    }
                }
                if (close)
                {
                    return 0;
                }

                // Move left pointer until a value greater than or equal to pivot is found
                while (arr[left] < pivot)
                {
                    left++;
                    porovnani++;
                }

                // Move right pointer until a value less than or equal to pivot is found
                while (arr[right] > pivot)
                {
                    right--;
                    porovnani++;
                }

                // If left pointer is still smaller than right pointer, swap elements
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    Swap(arr, left, right);
                    if (close)
                    {
                        return 0;
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        lbPorovnani.Text = "Number of comparisons: " + porovnani;

                        cas = stopwatch.Elapsed.TotalMilliseconds;
                        lbCas.Text = "Elapsed time: " + cas + " ms";
                    });
                    porovnani++;
                }
                else
                {
                    // Return the right pointer indicating the partitioning position
                    return right;
                }
            }
        }

        void BogoSort(int[] arr)
        {
            Random random = new Random();

            while (!IsSorted(arr))
            {
                Shuffle(arr, random);
                if (close)
                {
                    return;
                }

                if (fMode)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        okno.Refresh();
                        lbPorovnani.Text = "Number of comparisons: " + porovnani;

                        cas = stopwatch.Elapsed.TotalMilliseconds;
                        lbCas.Text = "Elapsed time: " + cas + " ms";
                    });
                }
            }
        }

        bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }

                porovnani++;
                if (!fMode)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lbPorovnani.Text = "Number of comparisons: " + porovnani;

                        cas = stopwatch.Elapsed.TotalMilliseconds;
                        lbCas.Text = "Elapsed time: " + cas + " ms";
                    });
                }
            }
            return true;
        }

        void Shuffle(int[] arr, Random random)
        {
            int n = arr.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);

                Swap(arr, k, n);
                if (close)
                {
                    return;
                }
            }
        }


        public void Sort(int[] array)
        {
            int n = array.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);

                this.Invoke((MethodInvoker)delegate
                {
                    okno.Refresh();
                    lbPorovnani.Text = "Number of comparisons: " + porovnani;

                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";
                });
            }

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                Swap(array, 0, i);

                // call max heapify on the reduced heap
                Heapify(array, i, 0);
                if (close)
                {
                    return;
                }

                this.Invoke((MethodInvoker)delegate
                {
                    okno.Refresh();
                    lbPorovnani.Text = "Number of comparisons: " + porovnani;

                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";
                });
            }
        }

        void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && array[l] > array[largest])
                largest = l;

            porovnani++;

            // If right child is larger than largest so far
            if (r < n && array[r] > array[largest])
                largest = r;

            porovnani++;

            if (close)
            {
                return;
            }
            // If largest is not root
            if (largest != i)
            {
                Swap(array, i, largest);
                if (close)
                {
                    return;
                }

                // Recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }

            porovnani++;
        }




        // Metoda pro prohození prvků v poli
        void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;

            Color color = Color.Red;

            // Vyplnění obdélníků odpovídající barvou
            using (SolidBrush brush = new SolidBrush(color))
            {
                using (Graphics g = okno.CreateGraphics())
                {
                    g.FillRectangle(brush, rectangles[i]);
                    g.FillRectangle(brush, rectangles[j]);
                }
            }

            rectangles[i].Y = (489 - 10) - Map(array[i], pocet, 360);   //musim změnit jak height tak i Y, potřebuju dát height na 10
            rectangles[i].Height = Map(array[i], pocet, 360);

            rectangles[j].Y = (489 - 10) - Map(array[j], pocet, 360);
            rectangles[j].Height = Map(array[j], pocet, 360);

            while (!start)
            {
                if (close)
                {
                    return;
                }
            }

            if (!fMode)
            {

                this.Invoke((MethodInvoker)delegate
                {
                    // Přidání zpoždění (např. 100 ms)
                    Thread.Sleep(delay);

                    // Aktualizace okna po každém kroku
                    okno.Refresh();
                });
            }
            zapisy++;
            this.Invoke((MethodInvoker)delegate
            {
                lbZapis.Text = "Number of entries: " + zapisy;
            });
        }

        public void GenPole()
        {
            // Vytvoření pole s čísly od 1 do 30
            numbers = Enumerable.Range(1, pocet).ToArray();

            // Vytvoření instance generátoru náhodných čísel
            Random random = new Random();

            // Protiření pole a pro každý prvek provést náhodnou výměnu s jiným prvkem
            for (int i = 0; i < numbers.Length; i++)
            {
                int randomIndex = random.Next(i, numbers.Length);
                int temp = numbers[i];
                numbers[i] = numbers[randomIndex];
                numbers[randomIndex] = temp;
            }
        }

        static int Map(int value, int originalMax, int newMax)
        {
            int originalMin = 0;
            int newMin = 1;

            // Normalizace vstupního čísla na původní rozsah
            double normalizedValue = (double)(value - originalMin) / (originalMax - originalMin);

            // Mapování normalizované hodnoty na nový rozsah
            int mappedValue = (int)(normalizedValue * (newMax - newMin) + newMin);

            return mappedValue;
        }

        public static void Kontrola(int[] arr, int pocet)
        {
            if (close)
            {
                return;
            }
            int n = arr.Length;

            Color barva = Color.Green;

            // Vyplnění obdélníků odpovídající barvou
            using (SolidBrush brush = new SolidBrush(barva))
            {
                using (Graphics g = okno.CreateGraphics())
                {
                    for (int i = 0; i < n; i++)
                    {
                        g.FillRectangle(brush, rectangles[i]);
                        Thread.Sleep(2000 / pocet);
                    }
                }
            }

            algChosen = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Vykreslení obdélníků
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            foreach (Rectangle rect in rectangles)
            {
                g.DrawRectangle(pen, rect);
            }
        }

        void resetForm()
        {
            rectangles = null;
            okno = null;
            numbers = null;
            start = false;
            algChosen = false;
            close = false;
        }

        private void trbr_speed_ValueChanged(object sender, EventArgs e)
        {
            if (trbr_speed.Value == 0)
            {
                fMode = true;
                tb_speed.Text = "TURBO";
            }
            else if (delay > trbr_speed.Maximum)
            {
                fMode = false;
            }
            else
            {
                tb_speed.Text = Convert.ToString(trbr_speed.Value);
                fMode = false;
                delay = trbr_speed.Value;
            }
        }

        private void tb_speed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tb_speed.Text) != trbr_speed.Value)
                {
                    if (Convert.ToInt32(tb_speed.Text) > trbr_speed.Maximum)
                    {
                        delay = Convert.ToInt32(tb_speed.Text);
                        trbr_speed.Value = trbr_speed.Maximum;
                    }
                    else
                    {
                        delay = Convert.ToInt32(tb_speed.Text);
                        trbr_speed.Value = Convert.ToInt32(tb_speed.Text);
                    }
                }
            }
            catch
            {
            }
        }

        private async void pb_start_Click(object sender, EventArgs e)
        {
            start = !start;
            picInt++;
            pb_start.Image = imageList1.Images[picInt % 2];

            if (algChosen)
            {
                return;
            }

            algChosen = true;

            switch (algoritmus)
            {
                case 1:
                    stopwatch = new Stopwatch();
                    stopwatch.Start();

                    //BubbleSortAlgorithm(numbers, pocet);
                    await Task.Run(() => BubbleSortAlgorithm(numbers, pocet));

                    stopwatch.Stop();
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";

                    okno.Refresh();
                    Kontrola(numbers, pocet);
                    break;
                case 2:
                    stopwatch = new Stopwatch();
                    stopwatch.Start();

                    //OddEvenSortAlgorithm(numbers, pocet);
                    await Task.Run(() => OddEvenSortAlgorithm(numbers, pocet));

                    stopwatch.Stop();
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";

                    okno.Refresh();
                    Kontrola(numbers, pocet);
                    break;
                case 3:
                    stopwatch = new Stopwatch();
                    stopwatch.Start();

                    //Quick_Sort(numbers, 0, pocet - 1);
                    await Task.Run(() => Quick_Sort(numbers, 0, pocet - 1));

                    stopwatch.Stop();
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";

                    okno.Refresh();
                    Kontrola(numbers, pocet);
                    break;
                case 4:
                    stopwatch = new Stopwatch();
                    stopwatch.Start();

                    //BogoSort(numbers);
                    await Task.Run(() => BogoSort(numbers));

                    stopwatch.Stop();
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";

                    okno.Refresh();
                    Kontrola(numbers, pocet);
                    break;
                case 5:
                    stopwatch = new Stopwatch();
                    stopwatch.Start();

                    //Sort(numbers);
                    await Task.Run(() => Sort(numbers));

                    stopwatch.Stop();
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";

                    okno.Refresh();
                    Kontrola(numbers, pocet);
                    break;
                case 6:
                    stopwatch = new Stopwatch();
                    stopwatch.Start();

                    //funkce ---------------

                    stopwatch.Stop();
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    lbCas.Text = "Elapsed time: " + cas + " ms";

                    okno.Refresh();
                    Kontrola(numbers, pocet);
                    break;
                // Další case případně můžeš přidat další hodnoty
                default:
                    // Příkazy, které se provedou, pokud žádný case neodpovídá výrazu
                    break;
            }
            if (close)
            {
                okno.Dispose();
            }
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            close = true;
            if (!algChosen)
            {
                this.Dispose();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
