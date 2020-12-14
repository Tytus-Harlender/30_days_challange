
namespace Day1
{
    public class TwinsImplementation : IFirstTwin, ISecondTwin
    {
        void IFirstTwin.DefineMe()
        {


        }
        void IFirstTwin.DefineMeAsWell()
        {


        }
        void ISecondTwin.DefineMe()
        {


        }
        void ISecondTwin.DefineMeAsWell()
        {


        }


    }

    public class MethodsChanger
    {
        public static void CastTheMethods()
        {
            TwinsImplementation twinsImplementation = new TwinsImplementation();
            
            IFirstTwin twin = twinsImplementation;
            twin.DefineMe();
            
            ((ISecondTwin)twinsImplementation).DefineMe();

        }




    }
}
