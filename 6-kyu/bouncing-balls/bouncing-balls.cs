public class BouncingBall
{
  
  public static int bouncingBall(double h, double bounce, double window)
  {
      if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
      {
        return -1;
      }
      int times = 0;
      
      if (h > window)
      {
        times++;
      }
    
      while ((h *= bounce) > window)
      {
          times++;
          times++;
      }
      return times;
  }
}