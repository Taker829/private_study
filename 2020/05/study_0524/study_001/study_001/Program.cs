using System;
using static System.Console;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            // 온도 -5 ~ 42도 외의 영역에 대해서는 예외처리
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            // temperature는 protected로 수식되었다. 이로 인해 외부에서 직접 접근할 수 없다.
            // 이렇게 public 메소드를 통해 접근해야한다.
            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            WriteLine($"Turn on water : {temperature}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
