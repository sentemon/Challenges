public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double[] ans = {celsius +  273.15, celsius * 1.80 + 32.00};

        return ans;
    }
}