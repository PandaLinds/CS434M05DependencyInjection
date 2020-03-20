using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Bike controlled by the player
        public Bike m_PlayerBike;

        // Bike controlled by an android (AI)
        public Bike m_AndroidBike1;
        public Bike m_AndroidBike2;
        public Bike m_AndroidBike3;

        void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();

            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();

            // Set up these bikes with a AI driver and a different engines
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();

            m_AndroidBike1.SetEngine(nitroEngine);
            m_AndroidBike1.SetDriver(androidDriver);
            m_AndroidBike1.StartEngine();

            IEngine oilEngine = new OrganicFryOilEngine();
            IDriver androidDriver2 = new AndroidDriver2();

            m_AndroidBike2.SetEngine(oilEngine);
            m_AndroidBike2.SetDriver(androidDriver2);
            m_AndroidBike2.StartEngine();

            IEngine teslaEngine = new TeslaEngine();
            IDriver androidDriver3 = new AndroidDriver3();

            m_AndroidBike3.SetEngine(teslaEngine);
            m_AndroidBike3.SetDriver(androidDriver3);
            m_AndroidBike3.StartEngine();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerBike.TurnLeft();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerBike.TurnRight();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
        }
    }
}