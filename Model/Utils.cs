using System;



namespace TP1.Model
{
    public class Utilities
    {
        static public float MostSignificantDigit(float Value)
        {
            float n = 1;

            float val_abs = Math.Abs(Value);
            float sig = 1.0f * Math.Sign(Value);

            if (val_abs > 1)
            {
                while (n < val_abs)
                {
                    n *= 10.0f;
                }

                return (float)((int)(sig * n / 10));
            }
            else
            {
                while (n > val_abs)
                {
                    n /= 10.0f;
                }

                return sig * n;
            }
        }
    }
}