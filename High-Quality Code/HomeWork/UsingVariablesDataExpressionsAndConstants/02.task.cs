/// <summary>
/// ///
/// </summary>
class Task02
{
    /// <summary>
    /// //
    /// </summary>
    /// <param name="max"></param>
    public void PrintMax(double max);
    
    /// <summary>
    /// ///////
    /// </summary>
    /// <param name="max"></param>
    public void PrintMin(double max);
    
    /// <summary>
    /// ///
    /// </summary>
    /// <param name="max"></param>
    public void PrintAvg(double max);

    /// <summary>
    /// ///
    /// </summary>
    /// <param name="arrayOfElements"></param>
    /// <param name="count"></param>
    public void PrintStatistics(double[] arrayOfElements, int count)
    {
        double maxValue = 0;
        for (int i = 0; i < count; i++)
        {
            if (arrayOfElements[i] > maxValue)
            {
                maxValue = arrayOfElements[i];
            }
        }

        this.PrintMax(maxValue);

        double minValue = 0;
        for (int i = 0; i < count; i++)
        {
            if (arrayOfElements[i] < minValue)
            {
                minValue = arrayOfElements[i];
            }
        }

        this.PrintMin(maxValue);

        double sumOfValues = 0;
        for (int i = 0; i < count; i++)
        {
            sumOfValues += arrayOfElements[i];
        }
        
        double averageValue = sumOfValues / count;
        this.PrintAvg(averageValue);
    }
}
