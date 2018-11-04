using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task_dev_5
{
    // Read data from file, check for correctness and add in List
    class CarsAdder
    {
        List<string> optionCar = new List<string>();
        string[] optCar;
        // Read data from a file and call Add();
        public List<string> CarsAdd(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    optCar = line.Split(' ');
                    if (optCar.Length == 4)
                    {
                        // list of cars is empty
                        if (optionCar.Count == 0)
                        {
                            foreach (string str in optCar)
                            {
                                optionCar.Add(str);
                            }
                        }
                        else
                        {
                            Add();
                        }
                    }
                    else
                    {
                        throw new Exception("Incorrectable input of data");
                    }
                }
            }
            return optionCar;
        } 
        // Add cars with new brand
        public void Add()
        {   
            // i - Brand, i+1 - model, i + 2 - countAll, i + 3 = price one
            for (int i = 0; i < optionCar.Count; i+=4)
            {
                if (CheckBeforeAdd(i) == false)
                {
                    foreach(string str in optCar)
                    {
                        optionCar.Add(str);
                    }
                }
            }
        }
        // checks for correct input of model macro and price
        // return true, if such a brand has already been another return false
        // if input Incorrectable throw Exception
        public bool CheckBeforeAdd(int i)
        {
            // checks that cars with a certain brand have the same price and model
            if (optionCar[i] == optCar[0])
            {   // i - Brand, i+1 - model, i + 2 - countAll, i+3 = price one
                if (optionCar[i + 1] == optCar[1] && optionCar[i + 3] != optCar[3])
                {
                    throw new Exception("Incorrectable input of data");
                }
                if(optionCar[i + 3] != optCar[3])
                {
                    throw new Exception("Incorrectable input of data");
                }
                optionCar[i + 2] = (int.Parse(optionCar[i + 2]) + int.Parse(optCar[2])).ToString();
                return true;
            }
            return false;
        }
    }
}

