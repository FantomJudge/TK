namespace TKNS
{ 

    public class Programm
    {

        public class Appraiser
        {
            int[] points;

            public Appraiser() {
                points = new int[3];
            }

            public void WriteGrades() {
                Console.WriteLine("Укажите колличество баллов по дисциплинам: ");

                Console.Write("Разработка, администрирование и защита баз данных: ");
                int point = Console.Read();
                if (this.CheckNum(point, 22)) {
                    points[0] = point;
                }
                
                Console.WriteLine("");
                Console.Write("Разработка модулей программного обеспечения для компьютерных систем: ");
                point = Console.Read();
                if (this.CheckNum(point, 38))
                {
                    points[1] = point;
                }

                Console.WriteLine("");
                Console.Write("Сопровождение и обслуживание программного обеспечения компьютерных систем»: ");
                point = Console.Read();
                if (this.CheckNum(point, 20))
                {
                    points[2] = point;
                }

                Console.WriteLine("");

                CheckNumSum(points);
                Console.WriteLine(Grade(points));
            }

            public int Grade(int[] grades) 
            {
                int sumPoints = grades.Sum();

                CheckNumsArray(grades);

                if (sumPoints <= 15)
                {
                    return 2;
                } else if (sumPoints >= 16 && sumPoints <= 31)
                {
                    return 3;
                }
                else if (sumPoints >= 32 && sumPoints <= 55)
                {
                    return 4;
                }
                else if (sumPoints >= 56 && sumPoints <= 80)
                {
                    return 5;
                }
                return 0;
            }

            public bool CheckNum(int num, int max)
            {
                if (num >= 0 && num <= max)
                {
                    return true;
                }
                throw new ArgumentException($"колличество балло не может быть меньше 0 и больше {max}");
                return false;
            }

            public bool CheckNumSum(int[] num)
            {
                if (num.Sum() >= 0 && num.Sum() <= 80)
                {
                    return true;
                }
                throw new ArgumentException("Сумма боллов больше 80");
                return false;
            }

            public void CheckNumsArray(int[] nums)
            {
                if (nums.Length != 3)
                {
                    throw new ArgumentException("Неверное колличество баллов");
                }

                CheckNum(nums[0], 22);
                CheckNum(nums[0], 38);
                CheckNum(nums[0], 20);

            }


        }


        static void Main()
        {

        }
    }
}
