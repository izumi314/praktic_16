using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace Zadanie_16
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeTaskComboBox();
        }

        private void InitializeTaskComboBox()
        {
            for (int i = 1; i <= 30; i++)
            {
                TaskComboBox.Items.Add($"Task {i}");
            }
            TaskComboBox.SelectedIndex = 0;
        }

        private void TaskComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (TaskComboBox.SelectedIndex >= 0)
            {
                UpdateTaskDescription(TaskComboBox.SelectedIndex + 1);
            }
        }

        private void UpdateTaskDescription(int taskNumber)
        {
            string description = GetTaskDescription(taskNumber);
            DescriptionTextBox.Text = description;
        }

        private string GetTaskDescription(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1: return "Дан файл f, компоненты которого являются действительными числами. Найти произведение компонент файла.";
                case 2: return "Дан файл f, компоненты которого являются целыми числами. Никакая из компонент файла не равна нулю. Файл f содержит столько же отрицательных чисел, сколько и положительных. Используя вспомогательный файл h, переписать компоненты файла f в файл g так, чтобы в файле g сначала шли положительные, потом отрицательные числа.";
                case 3: return "Дан файл f, компоненты которого являются целыми числами. Получить в файле g все компоненты файла f, являющиеся точными квадратами.";
                case 4: return "Дан файл f, компоненты которого являются действительными числами. Найти сумму наибольшего и наименьшего из значений компонент.";
                case 5: return "Дан файл, содержащий различные даты. Каждая дата - это число, месяц года. Найти год с наибольшим количеством дат и напечатать номера месяцев.";
                case 6: return "Дан файл f, компоненты которого являются действительными числами. Найти модуль суммы и квадрат произведения компонент файла.";
                case 7: return "Дан файл f, компоненты которого являются действительными числами. Найти разницу между первой и последней компонентой файла.";
                case 8: return "Дан файл f, компоненты которого являются целыми числами. Найти количество чётных чисел среди компонент.";
                case 9: return "Дан символьный файл f. Получить копию файла в файле g.";
                case 10: return "Даны символьные файлы f и g. Переплести их с сохранением порядка следования компонент в файл h. Использовать вспомогательный файл.";
                case 11: return "Дан файл f, компоненты которого являются действительными числами. Найти сумму компонент файла.";
                case 12: return "Дан символьный файл f, в файле не менее двух компонент. Определить, являются ли два первых символа файла цифрами. Если да, то установить, является ли число, образованное этими цифрами чётным.";
                case 13: return "Дан файл f, компоненты которого являются целыми числами. Получить в файле g все компоненты файла f, являющиеся чётными числами.";
                case 14: return "Дан файл f, компоненты которого являются действительными числами. Найти наибольшее из значений модулей компонент с чётными номерами.";
                case 15: return "Дан файл f, компоненты которого являются действительными числами. Найти последнюю компоненту файла.";
                case 16: return "Дан файл, содержащий различные даты. Каждая дата - это число, месяц и год. Найти все весенние даты.";
                case 17: return "Дан файл f, компоненты которого являются целыми числами. Получить в файле g все компоненты файла f, делящиеся на 3 и не делящиеся на 7.";
                case 18: return "Дан файл f, компоненты которого являются действительными числами. Найти наименьшее из значений компонент с чётными номерами.";
                case 19: return "Записать в файл g все чётные числа файла f, а в файл h все нечётные. Порядок следования чисел сохраняется.";
                case 20: return "Дан символьный файл f. Записать в файл g компоненты файла f в обратном порядке.";
                case 21: return "Дан файл, содержащий различные даты. Каждая дата - это число, месяц и год. Найти самую позднюю дату.";
                case 22: return "Даны символьные файлы f и g. Записать в файл h сначала компоненты файла f, затем компоненты файла g с сохранением порядка.";
                case 23: return "Дан файл f, компоненты которого являются целыми числами. Никакая из компонент файла не равна нулю. Файл f содержит столько же отрицательных чисел, сколько и положительных. Используя вспомогательный файл h, переписать компоненты файла f в файл g так, чтобы в файле g не было двух соседних чисел с одним знаком.";
                case 24: return "Дан файл f, компоненты которого являются целыми числами. Найти количество квадратов нечётных чисел среди компонент.";
                case 25: return "Дан файл f, компоненты которого являются действительными числами. Найти сумму квадратов компонент файла.";
                case 26: return "Дан файл f, компоненты которого являются действительными числами. Найти разность кубов компонент файла.";
                case 27: return "Дан файл f, компоненты которого являются целыми числами. Найти количество удвоенных нечётных чисел среди компонент.";
                case 28: return "Дан файл f, компоненты которого являются целыми числами. Никакая из компонент файла не равна нулю. Файл f содержит столько же отрицательных чисел, сколько и положительных. Используя вспомогательный файл h, переписать компоненты файла f в файл g так, чтобы в файле g числа шли в следующем порядке: два положительных два отрицательных, два положительных, два отрицательных и т.д. (предполагается, что число компонент в файле f делится на 4).";
                case 29: return "Дан файл, содержащий различные даты. Каждая дата - это число, месяц и год. Найти самую раннюю дату.";
                case 30: return "Дан файл f, компоненты которого являются целыми числами. Никакая из компонент файла не равна нулю. Файл f содержит столько же отрицательных чисел, сколько и положительных. Используя вспомогательный файл h, переписать компоненты файла f в файл g так, чтобы в файле g сначала шли нечетные потом четные числа.";
                default: return "Неизвестная задача";
            }
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskComboBox.SelectedIndex < 0) return;

            int taskNumber = TaskComboBox.SelectedIndex + 1;
            string input = InputTextBox.Text;

            try
            {
                string result = SolveTask(taskNumber, input);
                OutputTextBox.Text = result;
                StatusTextBlock.Text = $"Task {taskNumber} completed successfully";
            }
            catch (Exception ex)
            {
                OutputTextBox.Text = $"Error: {ex.Message}";
                StatusTextBlock.Text = $"Error in Task {taskNumber}";
            }
        }

        private string SolveTask(int taskNumber, string input)
        {
            switch (taskNumber)
            {
                case 1: return SolveTask1(input);
                case 2: return SolveTask2(input);
                case 3: return SolveTask3(input);
                case 4: return SolveTask4(input);
                case 5: return SolveTask5(input);
                case 6: return SolveTask6(input);
                case 7: return SolveTask7(input);
                case 8: return SolveTask8(input);
                case 9: return SolveTask9(input);
                case 10: return SolveTask10(input);
                case 11: return SolveTask11(input);
                case 12: return SolveTask12(input);
                case 13: return SolveTask13(input);
                case 14: return SolveTask14(input);
                case 15: return SolveTask15(input);
                case 16: return SolveTask16(input);
                case 17: return SolveTask17(input);
                case 18: return SolveTask18(input);
                case 19: return SolveTask19(input);
                case 20: return SolveTask20(input);
                case 21: return SolveTask21(input);
                case 22: return SolveTask22(input);
                case 23: return SolveTask23(input);
                case 24: return SolveTask24(input);
                case 25: return SolveTask25(input);
                case 26: return SolveTask26(input);
                case 27: return SolveTask27(input);
                case 28: return SolveTask28(input);
                case 29: return SolveTask29(input);
                case 30: return SolveTask30(input);
                default: throw new ArgumentException("Unknown task number");
            }
        }

        #region Task Solutions

        private string SolveTask1(string input)
        {
            double[] numbers = ParseNumbers(input);
            double product = 1;
            foreach (double num in numbers)
            {
                product *= num;
            }
            return $"Product of components: {product}";
        }

        private string SolveTask2(string input)
        {
            int[] numbers = ParseIntNumbers(input);

            
            if (numbers.Any(n => n == 0)) return "Error: File contains zero";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Error: Number of positive and negative numbers is not equal";

           
            var sorted = numbers.Where(n => n > 0).Concat(numbers.Where(n => n < 0));

            return "Sorted numbers (positive first, then negative):\n" + string.Join(", ", sorted);
        }

        private string SolveTask3(string input)
        {
            int[] numbers = ParseIntNumbers(input);
            var squares = numbers.Where(n =>
            {
                int root = (int)Math.Sqrt(n);
                return root * root == n;
            });

            return "Perfect squares:\n" + string.Join(", ", squares);
        }

        private string SolveTask4(string input)
        {
            double[] numbers = ParseNumbers(input);
            double min = numbers.Min();
            double max = numbers.Max();
            return $"Min: {min}, Max: {max}, Sum: {min + max}";
        }

        private string SolveTask5(string input)
        {
            var dates = ParseDates(input);
            var yearGroups = dates.GroupBy(d => d.Year)
                                .OrderByDescending(g => g.Count())
                                .First();

            return $"Year with most dates: {yearGroups.Key}\n" +
                   $"Month numbers: {string.Join(", ", yearGroups.Select(d => d.Month))}";
        }

        private string SolveTask6(string input)
        {
            double[] numbers = ParseNumbers(input);
            double sum = numbers.Sum();
            double product = numbers.Aggregate(1.0, (acc, num) => acc * num);

            return $"Absolute sum: {Math.Abs(sum)}\n" +
                   $"Square of product: {product * product}";
        }
        private string SolveTask7(string input)
        {
            double[] numbers = ParseNumbers(input);
            if (numbers.Length < 1) return "Error: File is empty";

            double diff = numbers[0] - numbers[numbers.Length - 1];
            return $"Difference between first and last component: {diff}";
        }

        private string SolveTask8(string input)
        {
            int[] numbers = ParseIntNumbers(input);
            int evenCount = numbers.Count(n => n % 2 == 0);
            return $"Number of even numbers: {evenCount}";
        }

        private string SolveTask9(string input)
        {
            return $"Copy of input file:\n{input}";
        }

        private string SolveTask10(string input)
        {
            
            string[] parts = input.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2) return "Error: Need content of both files f and g";

            string fContent = parts[0];
            string gContent = parts[1];

            var fChars = fContent.ToCharArray();
            var gChars = gContent.ToCharArray();

            var interleaved = new List<char>();
            int maxLength = Math.Max(fChars.Length, gChars.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < fChars.Length) interleaved.Add(fChars[i]);
                if (i < gChars.Length) interleaved.Add(gChars[i]);
            }

            return "Interleaved content:\n" + new string(interleaved.ToArray());
        }

        private string SolveTask11(string input)
        {
            double[] numbers = ParseNumbers(input);
            return $"Sum of components: {numbers.Sum()}";
        }

        private string SolveTask12(string input)
        {
            if (input.Length < 2) return "Error: File has less than 2 characters";

            char first = input[0];
            char second = input[1];

            if (char.IsDigit(first) && char.IsDigit(second))
            {
                int number = int.Parse(first.ToString()) * 10 + int.Parse(second.ToString());
                return $"First two characters form number: {number}\n" +
                       $"Is even: {number % 2 == 0}";
            }

            return "First two characters are not both digits";
        }

        private string SolveTask13(string input)
        {
            int[] numbers = ParseIntNumbers(input);
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            return "Even numbers:\n" + string.Join(", ", evenNumbers);
        }

        private string SolveTask14(string input)
        {
            double[] numbers = ParseNumbers(input);
            double maxAbsEvenIndex = 0;

            for (int i = 1; i < numbers.Length; i += 2) 
            {
                double abs = Math.Abs(numbers[i]);
                if (abs > maxAbsEvenIndex) maxAbsEvenIndex = abs;
            }

            return $"Max absolute value at even indices: {maxAbsEvenIndex}";
        }

        private string SolveTask15(string input)
        {
            double[] numbers = ParseNumbers(input);
            if (numbers.Length == 0) return "Error: File is empty";

            return $"Last component: {numbers[numbers.Length - 1]}";
        }

        private string SolveTask16(string input)
        {
            var dates = ParseDates(input);
            var springDates = dates.Where(d => d.Month >= 3 && d.Month <= 5);

            return "Spring dates:\n" + string.Join("\n", springDates.Select(d => d.ToString("dd.MM.yyyy")));
        }
        private string SolveTask17(string input)
        {
            int[] numbers = ParseIntNumbers(input);
            var result = numbers.Where(n => n % 3 == 0 && n % 7 != 0);
            return "Numbers divisible by 3 but not by 7:\n" + string.Join(", ", result);
        }

        private string SolveTask18(string input)
        {
            double[] numbers = ParseNumbers(input);
            double minEvenIndex = double.MaxValue;

            for (int i = 1; i < numbers.Length; i += 2) 
            {
                if (numbers[i] < minEvenIndex) minEvenIndex = numbers[i];
            }

            if (minEvenIndex == double.MaxValue) return "No even-indexed components";

            return $"Min value at even indices: {minEvenIndex}";
        }

        private string SolveTask19(string input)
        {
            int[] numbers = ParseIntNumbers(input);
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var oddNumbers = numbers.Where(n => n % 2 != 0);

            return "Even numbers:\n" + string.Join(", ", evenNumbers) + "\n\n" +
                   "Odd numbers:\n" + string.Join(", ", oddNumbers);
        }

        private string SolveTask20(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return "Reversed content:\n" + new string(chars);
        }

        private string SolveTask21(string input)
        {
            var dates = ParseDates(input);
            var latestDate = dates.Max();
            return $"Latest date: {latestDate.ToString("dd.MM.yyyy")}";
        }

        private string SolveTask22(string input)
        {
            string[] parts = input.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2) return "Error: Need content of both files f and g";

            return "Combined content (f then g):\n" + parts[0] + parts[1];
        }

        private string SolveTask23(string input)
        {
            int[] numbers = ParseIntNumbers(input);

           
            if (numbers.Any(n => n == 0)) return "Error: File contains zero";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Error: Number of positive and negative numbers is not equal";

           
            var positives = numbers.Where(n => n > 0).ToList();
            var negatives = numbers.Where(n => n < 0).ToList();

       
            var result = new List<int>();
            for (int i = 0; i < positives.Count; i++)
            {
                result.Add(positives[i]);
                result.Add(negatives[i]);
            }

            return "Alternating signs:\n" + string.Join(", ", result);
        }

        private string SolveTask24(string input)
        {
            int[] numbers = ParseIntNumbers(input);
            int count = numbers.Count(n =>
            {
                if (n % 2 != 0) return false;
                int root = (int)Math.Sqrt(n);
                return root * root == n && root % 2 != 0;
            });

            return $"Number of squares of odd numbers: {count}";
        }

        private string SolveTask25(string input)
        {
            double[] numbers = ParseNumbers(input);
            double sumOfSquares = numbers.Sum(n => n * n);
            return $"Sum of squares: {sumOfSquares}";
        }

        private string SolveTask26(string input)
        {
            double[] numbers = ParseNumbers(input);
            if (numbers.Length < 2) return "Error: Need at least 2 numbers";

            double diffOfCubes = Math.Pow(numbers[0], 3) - Math.Pow(numbers[1], 3);
            return $"Difference of cubes (first - second): {diffOfCubes}";
        }

        private string SolveTask27(string input)
        {
            int[] numbers = ParseIntNumbers(input);
            int count = numbers.Count(n => n % 2 == 0 && (n / 2) % 2 != 0);
            return $"Number of doubled odd numbers: {count}";
        }

        private string SolveTask28(string input)
        {
            int[] numbers = ParseIntNumbers(input);

            
            if (numbers.Any(n => n == 0)) return "Error: File contains zero";
            if (numbers.Length % 4 != 0) return "Error: Number of components must be divisible by 4";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Error: Number of positive and negative numbers is not equal";

            
            var positives = numbers.Where(n => n > 0).ToList();
            var negatives = numbers.Where(n => n < 0).ToList();

           
            var result = new List<int>();
            for (int i = 0; i < positives.Count; i += 2)
            {
                if (i + 1 < positives.Count)
                {
                    result.Add(positives[i]);
                    result.Add(positives[i + 1]);
                }

                if (i + 1 < negatives.Count)
                {
                    result.Add(negatives[i]);
                    result.Add(negatives[i + 1]);
                }
            }

            return "Two positive, two negative pattern:\n" + string.Join(", ", result);
        }

        private string SolveTask29(string input)
        {
            var dates = ParseDates(input);
            var earliestDate = dates.Min();
            return $"Earliest date: {earliestDate.ToString("dd.MM.yyyy")}";
        }

        private string SolveTask30(string input)
        {
            int[] numbers = ParseIntNumbers(input);

        
            if (numbers.Any(n => n == 0)) return "Error: File contains zero";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Error: Number of positive and negative numbers is not equal";

            
            var oddNumbers = numbers.Where(n => n % 2 != 0);
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            return "Odd numbers first, then even:\n" +
                   string.Join(", ", oddNumbers.Concat(evenNumbers));
        }

        #endregion

        #region Helper Methods

        private double[] ParseNumbers(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new double[0];

            string[] parts = input.Split(new[] { ' ', '\t', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Select(p => double.Parse(p)).ToArray();
        }

        private int[] ParseIntNumbers(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new int[0];

            string[] parts = input.Split(new[] { ' ', '\t', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Select(p => int.Parse(p)).ToArray();
        }
        private List<DateTime> ParseDates(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new List<DateTime>();

            string[] parts = input.Split(new[] { ' ', '\t', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var dates = new List<DateTime>();

            foreach (string part in parts)
            {
                string[] dateParts = part.Split('.');
                if (dateParts.Length == 3)
                {
                    int day = int.Parse(dateParts[0]);
                    int month = int.Parse(dateParts[1]);
                    int year = int.Parse(dateParts[2]);
                    dates.Add(new DateTime(year, month, day));
                }
                else if (dateParts.Length == 2)
                {
                    int day = int.Parse(dateParts[0]);
                    int month = int.Parse(dateParts[1]);
                    dates.Add(new DateTime(2000, month, day)); 
                }
            }

            return dates;
        }

        #endregion
    }
}
