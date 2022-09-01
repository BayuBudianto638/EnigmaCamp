using System;

public class Feline
{
    class Feline
    {
        protected int branchId { get; set; }
        protected string felineName { get; set; }
        protected string felineType { get; set; }

        public Feline()
        {

        }

        public Feline(int branchId, string felineName, string felineType)
        {
            this.branchId = branchId;
            this.felineName = felineName;
            this.felineType = felineType;
        }

        public void Update(int branchId, string felineName, string felineType)
        {
            this.branchId = branchId;
            this.felineName = felineName;
            this.felineType = felineType;
        }

        public void Mengeong(string felineName)
        {
            Console.WriteLine($"{felineName} Mengeong");
        }

        public void Mengaum(string felineName)
        {
            Console.WriteLine($"{felineName} Mengaum");
        }

        public override string ToString() =>
            $"{this.branchId} - {this.felineName} - {this.felineType}";
    }
}
