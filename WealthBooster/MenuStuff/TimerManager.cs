using System;
using System.Timers;

public static class TimerManager
{
    private static Timer sharedTimer;

    public static event ElapsedEventHandler SharedTimerTick;

    public static void StartTimer(double interval, ElapsedEventHandler tickHandler)
    {
        if (sharedTimer == null)
        {
            sharedTimer = new Timer(interval);
            sharedTimer.Elapsed += SharedTimerElapsed;
            sharedTimer.AutoReset = true;
        }

        SharedTimerTick += tickHandler;

        if (!sharedTimer.Enabled)
        {
            sharedTimer.Start();
        }
    }

    public static void StopTimer(ElapsedEventHandler tickHandler)
    {
        SharedTimerTick -= tickHandler;

        if (SharedTimerTick == null && sharedTimer != null && sharedTimer.Enabled)
        {
            sharedTimer.Stop();
            sharedTimer.Elapsed -= SharedTimerElapsed;
            sharedTimer.Dispose();
            sharedTimer = null;
        }
    }

    private static void SharedTimerElapsed(object sender, ElapsedEventArgs e)
    {
        SharedTimerTick?.Invoke(sender, e);
    }
}
