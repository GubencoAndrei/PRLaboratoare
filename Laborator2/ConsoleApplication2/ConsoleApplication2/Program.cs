using System;
using System.Threading;


public class MyThread
{
    static CountdownEvent _countdown = new CountdownEvent(1);
    static CountdownEvent _countdown2 = new CountdownEvent(1);
    static CountdownEvent _countdown3 = new CountdownEvent(1);

    public void Thread1()
    {
        {

            Thread thr = Thread.CurrentThread;
            Console.WriteLine(thr.Name);
            _countdown.Signal();
        }
    }


    public void Thread2()
    {
        {
            _countdown.Wait();
            Thread thr = Thread.CurrentThread;
            Console.WriteLine(thr.Name);
            _countdown2.Signal();
        }
    }


    public void Thread3()
    {
        {
            _countdown.Wait();
            Thread thr = Thread.CurrentThread;
            Console.WriteLine(thr.Name);
            Thread.Sleep(100);
            _countdown3.Signal();
        }
    }


    public void Thread4()
    {

        {
            _countdown3.Wait();
            Thread thr = Thread.CurrentThread;
            Console.WriteLine(thr.Name);
            
        }
    }

    public void Thread5()
    {
        {
            _countdown2.Wait();
            Thread thr = Thread.CurrentThread;
            Console.WriteLine(thr.Name);
            
        }
    }



    public void Thread6()
    {
        {
            _countdown2.Wait();
            Thread thr = Thread.CurrentThread;
            Console.WriteLine(thr.Name);
            
        }
    }


    public void Thread7()
    {
        {
            _countdown3.Wait();
            Thread thr = Thread.CurrentThread;
            Console.WriteLine(thr.Name);
            
        }
    }

}

public class MyClass
{

    public static void Main()
    {
        Console.WriteLine("Before start thread");

        MyThread thr1 = new MyThread();
        MyThread thr2 = new MyThread();
        MyThread thr3 = new MyThread();
        MyThread thr4 = new MyThread();
        MyThread thr5 = new MyThread();
        MyThread thr6 = new MyThread();
        MyThread thr7 = new MyThread();

        Thread tid1 = new Thread(new ThreadStart(thr1.Thread1));
        Thread tid2 = new Thread(new ThreadStart(thr2.Thread2));
        Thread tid3 = new Thread(new ThreadStart(thr3.Thread3));
        Thread tid4 = new Thread(new ThreadStart(thr4.Thread4));
        Thread tid5 = new Thread(new ThreadStart(thr5.Thread5));
        Thread tid6 = new Thread(new ThreadStart(thr6.Thread6));
        Thread tid7 = new Thread(new ThreadStart(thr7.Thread7));

        tid1.Name = "Thread 1";
        tid2.Name = "Thread 2";
        tid3.Name = "Thread 3";
        tid4.Name = "Thread 4";
        tid5.Name = "Thread 5";
        tid6.Name = "Thread 6";
        tid7.Name = "Thread 7";



        tid1.Start();
        tid2.Start();
        tid3.Start();
        tid4.Start();
        tid5.Start();
        tid6.Start();
        tid7.Start();

        Console.ReadLine();
    }
}


