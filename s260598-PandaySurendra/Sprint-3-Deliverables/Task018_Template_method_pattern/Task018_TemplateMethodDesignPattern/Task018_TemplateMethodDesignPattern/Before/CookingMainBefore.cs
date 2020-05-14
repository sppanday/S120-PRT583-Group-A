using System;
using Task018_TemplateMethodDesignPattern.Before;

namespace Task018_TemplateMethodDesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pasta pasta = new Pasta();

            Noodle noodle = new Noodle();

            // print all steps of cooking paasta
            pasta.heatPan();
            pasta.addOil();
            pasta.addNoodle();

            //print all steps of cooking pasta
            pasta.heatPan();
            pasta.addOil();
            pasta.addNoodle();
        }
    }
}
