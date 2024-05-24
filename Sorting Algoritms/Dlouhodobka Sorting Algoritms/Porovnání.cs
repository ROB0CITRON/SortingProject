using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class Porovnání : Form
    {
        #region Var
        Charts chartsTab;

        static Stopwatch stopwatch;

        static ProgressBar pbBubble;
        static ProgressBar pbOdd;
        static ProgressBar pbQuick;
        static ProgressBar pbBogo;
        static ProgressBar pbHeap;

        static CheckBox cbBubble;
        static CheckBox cbOdd;
        static CheckBox cbQuick;
        static CheckBox cbBogo;
        static CheckBox cbHeap;


        static Label lbBubbleCas;
        static Label lbBubblePorovnani;
        static Label lbBubbleZapis;
        static Label lbBubblePoradi;

        static Label lbOddCas;
        static Label lbOddPorovnani;
        static Label lbOddZapis;
        static Label lbOddPoradi;

        static Label lbQuickCas;
        static Label lbQuickPorovnani;
        static Label lbQuickZapis;
        static Label lbQuickPoradi;

        static Label lbBogoCas;
        static Label lbBogoPorovnani;
        static Label lbBogoZapis;
        static Label lbBogoPoradi;

        static Label lbHeapCas;
        static Label lbHeapPorovnani;
        static Label lbHeapZapis;
        static Label lbHeapPoradi;


        int[] numbers;
        static int pocet;
        static int porovnani = 0;
        static int zapis = 0;
        static double cas;
        static bool resBool = false;

        static double[] casy = new double[5];

        #endregion

        public Porovnání()
        {
            InitializeComponent();
        }

        private void Porovnání_Load(object sender, EventArgs e)
        {
            porovnani = 0;
            zapis = 0;

            pbBubble = pb_bubble;
            pbOdd = pb_odd;
            pbQuick = pb_quick;
            pbBogo = pb_bogo;
            pbHeap = pb_heap;

            cbBubble = cb_bubble;
            cbOdd = cb_odd;
            cbQuick = cb_quick;
            cbBogo = cb_bogo;
            cbHeap = cb_heap;

            lbBubblePoradi = lb_BubblePoradi;
            lbOddPoradi = lb_OddPoradi;
            lbQuickPoradi = lb_QuickPoradi;
            lbBogoPoradi = lb_BogoPoradi;
            lbHeapPoradi = lb_HeapPoradi;


            lbBubbleCas = lb_BubbleCas;
            lbBubblePorovnani = lb_BubblePorovnani;
            lbBubbleZapis = lb_BubbleZapis;

            lbOddCas = lb_OddCas;
            lbOddPorovnani = lb_OddPorovnani;
            lbOddZapis = lb_OddZapis;

            lbQuickCas = lb_QuickCas;
            lbQuickPorovnani = lb_QuickPorovnani;
            lbQuickZapis = lb_QuickZapis;

            lbBogoCas = lb_BogoCas;
            lbBogoPorovnani = lb_BogoPorovnani;
            lbBogoZapis = lb_BogoZapis;

            lbHeapCas = lb_HeapCas;
            lbHeapPorovnani = lb_HeapPorovnani;
            lbHeapZapis = lb_HeapZapis;
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            resBool = false;
            btn_start.Enabled = false;
            btn_start.BackColor = Color.LightGray;

            int repet = Convert.ToInt32(tb_repet.Text);

            if (repet <= 0)
                MessageBox.Show("ERROR\n\n" + "Choose number higher than 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            for (int i = 1; i <= repet; i++)
            {
                check.Text = $"{i}";
                Reset();

                #region Val
                try
                {
                    pocet = Convert.ToInt32(tb_pocet.Text);
                }
                catch
                {
                    MessageBox.Show("Enter the number in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (i > 1)
                {
                    pocet = pocet + Convert.ToInt32(tbAdd.Text);
                    tb_pocet.Text = Convert.ToString(pocet);
                }


                pbBubble.Maximum = pocet - 1;
                pbOdd.Maximum = (pocet * 2) - 1;
                pbHeap.Maximum = pocet - 1;
                pbQuick.Maximum = pocet + (pocet / 10);

                #endregion

                #region Sorts
                GenPole();
                await Task.Run(() => BubbleSortAlgorithm(numbers));
                porovnani = 0;
                zapis = 0;

                GenPole();
                await Task.Run(() => OddEvenSortAlgorithm(numbers));
                porovnani = 0;
                zapis = 0;

                GenPole();
                stopwatch = new Stopwatch();
                stopwatch.Start();
                await Task.Run(() => Quick_Sort(numbers, 0, pocet - 1));
                stopwatch.Stop();
                if (!cbQuick.Checked && !resBool)
                {
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    casy[2] = cas;
                    pbQuick.Value = pbQuick.Maximum;
                    lbQuickCas.Text = $"Time: {cas} ms";
                    lbQuickPorovnani.Text = $"Number of comparisons: {porovnani}";
                    lbQuickZapis.Text = $"Number of entries: {zapis}";
                }
                porovnani = 0;
                zapis = 0;

                GenPole();
                await Task.Run(() => BogoSort(numbers));
                stopwatch.Stop();
                if (!cbBogo.Checked && !resBool)
                {
                    pbBogo.Value = pbBogo.Maximum;
                    cas = stopwatch.Elapsed.TotalMilliseconds;
                    casy[2] = cas;
                    pbBogo.Value = pbBogo.Maximum;
                    lbBogoCas.Text = "Čas: " + cas + " ms";
                    lbBogoPorovnani.Text = "Počet porovnání: " + porovnani;
                    lbBogoZapis.Text = "Počet zápisů: " + zapis;
                }
                porovnani = 0;
                zapis = 0;

                GenPole();
                await Task.Run(() => HeapSort(numbers));
                #endregion

                #region Texts
                lbBubblePoradi.Text = "Order: " + NajdiPoradi(casy, 0);
                lbOddPoradi.Text = "Order: " + NajdiPoradi(casy, 1);
                lbQuickPoradi.Text = "Order: " + NajdiPoradi(casy, 2);
                lbBogoPoradi.Text = "Order: " + NajdiPoradi(casy, 3);
                lbHeapPoradi.Text = "Order: " + NajdiPoradi(casy, 4);
                #endregion

                if (resBool)
                {
                    if (chartsTab != null)
                    {
                        chartsTab.Dispose();
                    }
                    return;
                }
                ChartLoad();
                if (i == 1)
                    chartsTab.DisableCharts(cbBubble.Checked, cbOdd.Checked, cbQuick.Checked, cbBogo.Checked, cbHeap.Checked);

                chartsTab.UpdateCharts();
            }
        }

        #region Gen
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

        static int NajdiPoradi(double[] pole, int index)
        {
            // Vytvoření pole indexů seřazených hodnot (ignorujeme hodnoty rovné 0)
            int[] indexy = Enumerable.Range(0, pole.Length)
                                      .Where(i => pole[i] != 0)
                                      .ToArray();

            // Seřazení pouze ne-nulových hodnot
            double[] neNuloveHodnoty = indexy.Select(i => pole[i]).ToArray();
            Array.Sort(neNuloveHodnoty, indexy);

            // Vyhledání Order na základě indexu
            for (int i = 0; i < neNuloveHodnoty.Length; i++)
            {
                if (indexy[i] == index)
                {
                    return i + 1; // Order začíná od 1
                }
            }

            // Pokud index není nalezen, vrátit -1 nebo vhodnou hodnotu
            return 0;
        }
        #endregion

        #region Sorts
        void BubbleSortAlgorithm(int[] arr)
        {
            if (cbBubble.Checked)
                return;

            stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        if (resBool)
                        {
                            return;
                        }
                    }
                    porovnani++;
                }
                this.Invoke((MethodInvoker)delegate
                {
                    pbBubble.Value++;
                    pbBubble.Refresh();
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                stopwatch.Stop();
                cas = stopwatch.Elapsed.TotalMilliseconds;
                casy[0] = cas;

                lbBubbleCas.Text = $"Time: {cas} ms";
                lbBubblePorovnani.Text = $"Number of comparisons: {porovnani}";
                lbBubbleZapis.Text = $"Number of entries: {zapis}";
            });

        }

        static void Swap(int[] arr, int i, int j)
        {
            if (resBool)
            {
                return;
            }

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            zapis++;
        }

        // Metoda pro provádění odd-even sort
        void OddEvenSortAlgorithm(int[] arr)
        {
            if (cbOdd.Checked)
                return;

            stopwatch = new Stopwatch();
            stopwatch.Start();

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
                        if (resBool)
                        {
                            return;
                        }
                    }
                    porovnani++;
                }

                this.Invoke((MethodInvoker)delegate
                {
                    pbOdd.Value++;
                    pbOdd.Refresh();
                });

                for (int i = 0; i < n - 1; i += 2) // Sudá fáze
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        sorted = false;
                        if (resBool)
                        {
                            return;
                        }
                    }
                    porovnani++;
                }

                this.Invoke((MethodInvoker)delegate
                {
                    pbOdd.Value++;
                    pbOdd.Refresh();
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                pbOdd.Value = pbOdd.Maximum;

                stopwatch.Stop();
                cas = stopwatch.Elapsed.TotalMilliseconds;
                casy[1] = cas;

                lbOddCas.Text = $"Time: {cas} ms";
                lbOddPorovnani.Text = $"Number of comparisons: {porovnani}";
                lbOddZapis.Text = $"Number of entries: {zapis}";
            });
        }

        private void Quick_Sort(int[] arr, int left, int right)
        {
            if (cbQuick.Checked || resBool)
                return;

            // Check if there are elements to sort
            if (left < right)
            {
                if (resBool)
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
                if (resBool)
                {
                    return;
                }
            }
            this.Invoke((MethodInvoker)delegate
            {
                pbQuick.Value++;
                pbQuick.Refresh();
            });
        }

        // Method to partition the array
        static int Partition(int[] arr, int left, int right)
        {
            // Select the pivot element
            int pivot = arr[left];

            // Continue until left and right pointers meet
            while (true)
            {
                if (resBool)
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
                    if (resBool)
                    {
                        return 0; ;
                    }
                }
                else
                {
                    // Return the right pointer indicating the partitioning position
                    return right;
                }
            }
        }

        static void BogoSort(int[] arr)
        {
            if (cbBogo.Checked)
                return;

            Random random = new Random();
            stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!IsSorted(arr))
            {
                Shuffle(arr, random);
                if (resBool)
                {
                    return;
                }
            }
        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
                porovnani++;
            }
            pbBogo.Value = pbBogo.Maximum;

            stopwatch.Stop();
            cas = stopwatch.Elapsed.TotalMilliseconds;
            casy[3] = cas;

            lbBogoCas.Text = $"Time: {cas} ms";
            lbBogoPorovnani.Text = $"Number of comparisons: {porovnani}";
            lbBogoZapis.Text = $"Number of entries: {zapis}";
            return true;
        }

        static void Shuffle(int[] arr, Random random)
        {
            int n = arr.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);

                Swap(arr, k, n);
                if (resBool)
                {
                    return;
                }
            }
        }

        public void HeapSort(int[] array)
        {
            if (cbHeap.Checked)
                return;

            stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = array.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                Swap(array, 0, i);
                if (resBool)
                {
                    return;
                }

                // call max heapify on the reduced heap
                Heapify(array, i, 0);
                this.Invoke((MethodInvoker)delegate
                {
                    pbHeap.Value++;
                    pbHeap.Refresh();
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                stopwatch.Stop();
                cas = stopwatch.Elapsed.TotalMilliseconds;
                casy[4] = cas;

                lbHeapCas.Text = $"Time: {cas} ms";
                lbHeapPorovnani.Text = $"Number of comparisons: {porovnani}";
                lbHeapZapis.Text = $"Number of entries: {zapis}";
            });

        }

        void Heapify(int[] array, int n, int i)
        {
            if (resBool)
            {
                return;
            }
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

            // If largest is not root
            if (largest != i)
            {
                Swap(array, i, largest);
                if (resBool)
                {
                    return;
                }

                // Recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }

            porovnani++;
        }
        #endregion

        #region Btns
        private void btn_reset_Click(object sender, EventArgs e)
        {
            resBool = true;
            Reset();

        }

        void Reset()
        {
            pbBubble.Value = 0;
            pbOdd.Value = 0;
            pbQuick.Value = 0;
            pbBogo.Value = 0;
            pbHeap.Value = 0;

            for (int i = 0; i < 5; i++)
                casy[i] = 0;

            pocet = 0;
            zapis = 0;
            porovnani = 0;
            btn_start.BackColor = Color.White;
            btn_start.Enabled = true;

            lbBubbleCas.Text = "Time: 0 ms";
            lbBubblePorovnani.Text = "Number of comparisons: ??";
            lbBubbleZapis.Text = "Number of entries: ??";
            lbBubblePoradi.Text = "Order: ??";

            lbOddCas.Text = "Time: 0 ms";
            lbOddPorovnani.Text = "Number of comparisons: ??";
            lbOddZapis.Text = "Number of entries: ??";
            lbOddPoradi.Text = "Order: ??";

            lbQuickCas.Text = "Time: 0 ms";
            lbQuickPorovnani.Text = "Number of comparisons: ??";
            lbQuickZapis.Text = "Number of entries: ??";
            lbQuickPoradi.Text = "Order: ??";

            lbBogoCas.Text = "Time: 0 ms";
            lbBogoPorovnani.Text = "Number of comparisons: ??";
            lbBogoZapis.Text = "Number of entries: ??";
            lbBogoPoradi.Text = "Order: ??";

            lbHeapCas.Text = "Time: 0 ms";
            lbHeapPorovnani.Text = "Number of comparisons: ??";
            lbHeapZapis.Text = "Number of entries: ??";
            lbHeapPoradi.Text = "Order: ??";
        }

        void ChartLoad()
        {
            if (chartsTab == null || chartsTab.IsDisposed)
            {
                int pocet = Convert.ToInt32(tb_pocet.Text);

                double bubbleTime = cbBubble.Checked ? 0 : ConvertLabelToDouble(lbBubbleCas);
                double OddTime = cbOdd.Checked ? 0 : ConvertLabelToDouble(lbOddCas);
                double QuickTime = cbQuick.Checked ? 0 : ConvertLabelToDouble(lbQuickCas);
                double BogoTime = cbBogo.Checked ? 0 : ConvertLabelToDouble(lbBogoCas);
                double HeapTime = cbHeap.Checked ? 0 : ConvertLabelToDouble(lbHeapCas);

                chartsTab = new Charts(pocet, bubbleTime, OddTime,
                    QuickTime, BogoTime, HeapTime);
            }
            else
            {
                int pocet = Convert.ToInt32(tb_pocet.Text);

                double bubbleTime = cbBubble.Checked ? 0 : ConvertLabelToDouble(lbBubbleCas);
                double OddTime = cbOdd.Checked ? 0 : ConvertLabelToDouble(lbOddCas);
                double QuickTime = cbQuick.Checked ? 0 : ConvertLabelToDouble(lbQuickCas);
                double BogoTime = cbBogo.Checked ? 0 : ConvertLabelToDouble(lbBogoCas);
                double HeapTime = cbHeap.Checked ? 0 : ConvertLabelToDouble(lbHeapCas);

                chartsTab.UpdateData(pocet, bubbleTime, OddTime,
                    QuickTime, BogoTime, HeapTime);
            }

            chartsTab.Show();
            chartsTab.Activate();
        }

        private double ConvertLabelToDouble(Label label)
        {
            string text = label.Text;

            // Remove "Time: " and " ms" from the text
            text = text.Replace("Time:", "").Replace("ms", "").Trim();

            if (double.TryParse(text, out double result))
            {
                return result;
            }
            else
            {
                MessageBox.Show($"Invalid format for label {label.Name}. Using 0 instead.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        #endregion
    }
}
