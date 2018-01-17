using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class Cafe
    {
        //Default  Constructor
        public Cafe()
        {
            newlatte_coff = 0.0;
            newespresson = 0.0;
            newIcedLatte = 0.0;
            newVale_Coff = 0.0;
            newAfri_coff = 0.0;
            newAmre_coff = 0.0;
            newCappe_coff = 0.0;
            newIcapp_coff = 0.0;

            newc_cakes = 0.0;
            newvl_cakes = 0.0;
            newbF_cakes = 0.0;
            newcB_cakes = 0.0;
            newcL_cakes = 0.0;
            newcK_cakes = 0.0;
            newcC_cakes = 0.0;
            newcQ_cakes = 0.0;
        }
        //Overload Constrocgtor

            public Cafe(double latte_coff,double espresson,double IcedLatte,double Vale_Coff,double Afri_coff, double Amre_coff,double Cappe_coff, double Icapp_coff, double c_cakes,double vl_cakes,double bF_cakes,double cB_cakes,double cL_cakes,double cK_cakes,double cC_cakes,double cQ_cakes)
        {
            //Coffee
         newlatte_coff= latte_coff;
         newespresson= espresson;
         newIcedLatte= IcedLatte;
         newVale_Coff= Vale_Coff;
         newAfri_coff= Afri_coff;
         newAmre_coff= Amre_coff;
         newCappe_coff= Cappe_coff;
         newIcapp_coff= Icapp_coff;

         //Cakes
         newc_cakes= c_cakes;
         newvl_cakes= vl_cakes;
         newbF_cakes= bF_cakes;
         newcB_cakes= cB_cakes;
         newcL_cakes= cL_cakes;
         newcK_cakes= cK_cakes;
         newcC_cakes= cC_cakes;
         newcQ_cakes= cQ_cakes;

    }

        //Accessor Function
        //Coffee
        public double getlatte_coff()
        {
            return newlatte_coff;
        }
        public double getespresson()
        {
            return newespresson;
        }
        public double getIcedLatte()
        {
            return newIcedLatte;
        }
        public double getVale_Coff()
        {
            return newVale_Coff;
        }
        public double getAfri_coff()
        {
            return newAfri_coff;
        }
        public double getAmre_coff()
        {
            return newAmre_coff;
        }
        public double getCappe_coff()
        {
            return newCappe_coff;
        }
        public double getIcapp_coff()
        {
            return newIcapp_coff;
        }


        //Cakes
        public double getc_cakesf()
        {
            return newc_cakes;
        }
        public double getvl_cakes()
        {
            return newvl_cakes;
        }
        public double getbF_cakes()
        {
            return newbF_cakes;
        }
        public double getcB_cakes()
        {
            return newcB_cakes;
        }
        public double getcL_cakes()
        {
            return newcL_cakes;
        }
        public double getcK_cakes()
        {
            return newcK_cakes;
        }
        public double getcC_cakes()
        {
            return newcC_cakes;
        }
        public double getcQ_cakes()
        {
            return newcQ_cakes;
        }
        //Member Variables Declared For Coffee
        private double newlatte_coff;
        private double newespresson;
        private double newIcedLatte;
        private double newVale_Coff;
        private double newAfri_coff;
        private double newAmre_coff;
        private double newCappe_coff;
        private double newIcapp_coff;

        //Member Variables Declared For Cakes

        private double newc_cakes;
        private double newvl_cakes;
        private double newbF_cakes;
        private double newcB_cakes;
        private double newcL_cakes;
        private double newcK_cakes;
        private double newcC_cakes;
        private double newcQ_cakes;
    }
}
