namespace PickAndPlace
{
    public class SMD
    {
        public SMD(string designator, string package, string xAxis, string yAxis, string rotation, string partName)
        {
            Designator = designator;
            Package = package;
            XAxis = xAxis;
            YAxis = yAxis;
            Rotation = rotation;
            PartName = partName;
        }
        public string Designator { get; set; }
        public string Package { get; set; }
        public string XAxis { get; set; }
        public string YAxis { get; set; }
        public string Rotation { get; set; }
        public string PartName { get; set; }

        public override string ToString()
        {
            string output = $"\"{this.PartName} {this.Package}\" {this.Designator} {this.XAxis} {this.YAxis} {this.Rotation}";
            return output;
        }
    }
}


