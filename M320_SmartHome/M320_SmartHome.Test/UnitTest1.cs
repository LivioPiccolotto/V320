namespace M320_SmartHome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            static void Main(string[] args)
            {
                var wettersensor = new Wettersensor();
                var wohnung = new Wohnung(wettersensor);

                wohnung.SetTemperaturvorgabe("BadWC", 23);
                wohnung.SetTemperaturvorgabe("Kueche", 22);
                wohnung.SetTemperaturvorgabe("Schlafen", 19);
                wohnung.SetTemperaturvorgabe("Wohnen", 19);
                wohnung.SetTemperaturvorgabe("Wintergarten", 20);

                wohnung.SetPersonenImZimmer("Kueche", true);
                wohnung.SetPersonenImZimmer("Schlafen", false);
                wohnung.SetPersonenImZimmer("Wohnen", true);
                wohnung.SetPersonenImZimmer("Wintergarten", true);

                for (var i = 0; i < TimeSpan.FromHours(1).TotalMinutes; i++)
                {
                    wohnung.GenerateWetterdaten();
                }
            }
        }
    }
    }

// ICh komme hier nicht weiter, da ich die Temperatur in den jeweiligen Zimmer erhöhen und vertiefen kann, jedoch weiss ich nicht wie ich diese Ausgabe gestallten muss. Wie soll diese gestallten werden. Muss man sehen das dass System reagiert und nun etwas verändert wird oder wie soll das aussehen. Den dass wäre nunn der nächste Schritt und ohne diesen kann ich nicht weitermachen. 
