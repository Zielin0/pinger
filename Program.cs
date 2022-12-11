using System;
using System.Net;
using System.Net.NetworkInformation;

namespace Pinger
{
  class Program
  {
    static void Main(string[] args)
    {
      ipPing();
    }

    static void ipPing()
    {
      Console.Title = "IP Pinger by Zielino";
      WebClient client = new WebClient();
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("[+]");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write(" IP Pinger");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("          by Zielino");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write(" [+]");
      Console.WriteLine("");

      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("[+]");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write(" Discord:         ");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("Zielino#7342");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write(" [+]");

      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("[+]");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write(" Page:   ");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write(" https://siurasowo.surge.sh");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write(" [+]");

      Console.WriteLine("");
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Enter your target IP:");
      Console.Write(">> ");
      Console.ForegroundColor = ConsoleColor.Blue;
      string ip = Console.ReadLine();

      try
      {
        Ping p = new Ping();
        PingReply r;
        string s;
        s = ip;

        System.Threading.Thread.Sleep(1500);
        Console.Clear();
        while (true)
        {
          r = p.Send(s);
          if (r.Status == IPStatus.Success)
          {
            // color RED
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ping to " + s.ToString() + " Successful" + " Response delay = " + r.RoundtripTime.ToString() + " ms");
            System.Threading.Thread.Sleep(15);

            // color BLUE
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ping to " + s.ToString() + " Successful" + " Response delay = " + r.RoundtripTime.ToString() + " ms");
            System.Threading.Thread.Sleep(15);

            // color GREEN
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ping to " + s.ToString() + " Successful" + " Response delay = " + r.RoundtripTime.ToString() + " ms");
            System.Threading.Thread.Sleep(15);

            // color YELLOW
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ping to " + s.ToString() + " Successful" + " Response delay = " + r.RoundtripTime.ToString() + " ms");
            System.Threading.Thread.Sleep(15);

            // color wHITE
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ping to " + s.ToString() + " Successful" + " Response delay = " + r.RoundtripTime.ToString() + " ms");
            System.Threading.Thread.Sleep(15);

            if (r.Status == IPStatus.TimedOut)
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("Target is not responding!");
              System.Threading.Thread.Sleep(50);

              Console.ForegroundColor = ConsoleColor.Magenta;
              Console.WriteLine("Target is not responding!");
              System.Threading.Thread.Sleep(50);

              Console.ForegroundColor = ConsoleColor.White;
              Console.WriteLine("Target is not responding!");
              System.Threading.Thread.Sleep(50);

            }
          }
          else if (r.Status == IPStatus.TimedOut)
          {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your target is offline.");
            System.Threading.Thread.Sleep(1000);
            ipPing();
          }
        }
      }
      catch (Exception e)
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("An error occurred while");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" pinging");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(", or such");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" IP");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" does not exist.");
        Console.WriteLine("");
        Console.WriteLine("");
        System.Threading.Thread.Sleep(700);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("If you think it's a bug, contact");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" Zielino#7342");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(" on discord.");

        System.Threading.Thread.Sleep(7500);
        ipPing();
      }
    }
  }
}
