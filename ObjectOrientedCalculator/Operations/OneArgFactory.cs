namespace ObjectOrientedCalculator.Operations
{
    public static class OneArgFactory
    {
        public static IOneArgCalculator CreateObjectOrientedCalculator(string operation)
        {
            switch (operation)
            {
                case ("Exp"): return new Exp();
                case ("Sqrt"): return new Sqrt();
            }
            return null;
        }
    }
}