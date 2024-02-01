public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hh, mm, ss;
        hh = 0;
        mm = 0;
        ss = 0;
      
        string h, m, s;
        h = "";
        m = "";
        s = "";
      
        for (int i = 0; i < seconds; i++)
        {
            ss++;
            if (ss == 60)
            {
                mm++;
                ss = 0;
                if (mm == 60)
                {
                    hh++;
                    mm = 0;
                }
            }
        }
      
        if (hh.ToString().Length != 2)
            h = "0" + hh.ToString();
        else
            h = hh.ToString();
      
        if (mm.ToString().Length != 2)
            m = "0" + mm.ToString();
        else
            m = mm.ToString();
      
        if (ss.ToString().Length != 2)
            s = "0" + ss.ToString();
        else
            s = ss.ToString();
        
        return $"{h}:{m}:{s}";
    }
}