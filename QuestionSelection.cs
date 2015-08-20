using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enviormental_Issues_Quiz_Program
{
    class QuestionSelection
    {
        static Random _random = new Random();
        
        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
        
        public int[] selectQuestions()
        {
            int[] questionAll = new int[27] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27};

            Shuffle(questionAll);

            int[] questionSelected;
            questionSelected = new int[10];

            for (int i = 0; i < 10; i++)
            {
                questionSelected[i] = questionAll[i];
            }

            return questionSelected;
        }

        public string[] getQuestion(int questionSelected)
        {
            string[] question;
            question = new string[6];

            switch (questionSelected)
            {
                case 1:
                    question[0] = "Every year the world gathers for the COP meetings among the signatories of the United Nations Framework Convention on Cilmate Change. When was this convention signed?";
                    question[1] = "In 2007 in Bali,  in order to debate the successor of Kyoto";
                    question[2] = "In 1987 in Oslo, in the first meeting where countries adopted the concept of 'Sustainable Development'";
                    question[3] = "In 2002 in Johannesburg, as a follow-up to the Kyoto Protocol";
                    question[4] = "In 1992 during the Earth Summit in Rio de Janeiro";
                    question[5] = "3";
                    break;
                case 2:
                    question[0] = "At the 1992 Earth Submmit, two other major United Nations enviromental conventions were signed in addition to the climate one, and they also hold their own COP meetings. Which are they?";
                    question[1] = "The UN Convention on Biodiversity and the UN Convention to Combat Desertification";
                    question[2] = "The UN Convention on Nitrogen Pollutants and the UN Convention on Forests";
                    question[3] = "The UN Convention on Nitrogen Pollutants and the UN Convention to Combat Desertification";
                    question[4] = "The UN Convention on Biodiversity and the UN Convention on Forests";
                    question[5] = "1";
                    break;
                case 3:
                    question[0] = "In 1997 the Kyoto Protocol was launched and by now more than 190 countries have signed it. Which of these countries have not yet signed the Kyoto Protocol?";
                    question[1] = "Argentina";
                    question[2] = "Somalia";
                    question[3] = "Belarus";
                    question[4] = "United States";
                    question[5] = "3";
                    break;
                case 4:
                    question[0] = "China is now the largest emitter of carbon dioxide (CO2), followed by the United States. Who comes 3rd?";
                    question[1] = "Indonesia";
                    question[2] = "Japan";
                    question[3] = "Russia";
                    question[4] = "India";
                    question[5] = "2";
                    break;
                case 5:
                    question[0] = "The Kyoto Protocol came only into force in 2005, after Russia's ratification of the protocol. Why?";
                    question[1] = "The Protocol needed to include at least one of the 'Cold War Powers'";
                    question[2] = "Because Russia provided the international political support necessary for Kyoto to come into force";
                    question[3] = "Kyoto required at least one of the top 3 greenhouse gas emitter to adopt reduction targets (and neither China or the US have reduction targets)";
                    question[4] = "The protocol needed to include a total of countries responsible for at least 55% of the global emissions";
                    question[5] = "1";
                    break;
                case 6:
                    question[0] = "According t the Intergovernmental Panel on Climate Change (IPCC), what sectors are the largest emitters of greenhouse gases? (In order)";
                    question[1] = "Transport Sector, Agriculture, Energy generation";
                    question[2] = "Transport Sector, Energy Generation, Argiculture";
                    question[3] = "Industrial Production, Energy Generation, Transport Sector";
                    question[4] = "Energy Generation, Deforestation, Agriculture";
                    question[5] = "2";
                    break;
                case 7:
                    question[0] = "Which of these is not a fossil fuel?";
                    question[1] = "Natural Gas";
                    question[2] = "Kerosene";
                    question[3] = "Coal";
                    question[4] = "Uranium";
                    question[5] = "4";
                    break;
                case 8:
                    question[0] = "All these are foreseen impacts on climate change, except...";
                    question[1] = "Reduction of snow cover and likely impact on winter tourism in Europe";
                    question[2] = "The Amazon may partly become a savannah like vegetation";
                    question[3] = "Increased frequency of acid rain in North America";
                    question[4] = "Up to 50% reduction of agricultura yields in Africa";
                    question[5] = "1";
                    break;
                case 9:
                    question[0] = "The Kyoto Protocol requires developed countries to reduce their emissions by 5.2% compared to 1990 levels. The European Union has pledged to go even further and cut emissions by 20% by 2020. How much has Europe managed to achieve?";
                    question[1] = "2009 emissions in the EU-27 were 2.3% higher than in 1990";
                    question[2] = "2009 emissions in the EU-2 were the same as in 1990";
                    question[3] = "2009 emissions in the EU-27 were 5.6% lower than in 1990";
                    question[4] = "2009 emissions in the EU-27 were 17.3% lower than in 1990";
                    question[5] = "4";
                    break;
                case 10:
                    question[0] = "Despite progress in reducing emissions in Europe, performance has varied significantly among countries. The over-achievement of some have made up for the failure of others. Only one of the countries below actually met Kyoto targets. Which one?";
                    question[1] = "Switzerland";
                    question[2] = "Italy";
                    question[3] = "Denmark";
                    question[4] = "United Kingdom";
                    question[5] = "3";
                    break;
                case 11:
                    question[0] = "What percentage of growing Chinese emissions are associated to products exported to Europe and North America?";
                    question[1] = "80%";
                    question[2] = "17%";
                    question[3] = "9%";
                    question[4] = "45%";
                    question[5] = "4";
                    break;
                case 12:
                    question[0] = "One of the main arguments of develping countries is that, even if thei total greenhouse gas emissions are increasing, ther emissions per capita are still much lower than those of richer countries. Pick the correct statement:";
                    question[1] = "The average Nigerian emits 10x less then the average Italian";
                    question[2] = "The average US American emits 13x more than the average Indian";
                    question[3] = "The average Japanese emits more then the average German";
                    question[4] = "Switzerland has the highest emissions per capitia in Europe";
                    question[5] = "2";
                    break;
                case 13:
                    question[0] = "Which of these forms of biodiversity are considered particularly vulnerable to temperature changes in the global climate";
                    question[1] = "Small insects such mosquitoes and flies";
                    question[2] = "Algae and animals which live in humid soils";
                    question[3] = "Topical Fish and aquatic plants";
                    question[4] = "Amphibians and coral reefs";
                    question[5] = "1";
                    break;
                case 14:
                    question[0] = "How high is the current rate of biodiversity loss compared to the natural rate?";
                    question[1] = "500x higher";
                    question[2] = "50x higher";
                    question[3] = "10x higher";
                    question[4] = "5x higher";
                    question[5] = "3";
                    break;
                case 15:
                    question[0] = "Argicultural industrialization, too, has become seriously unsustainable. In the last 100 years, how much plant genetic diversity has been lost?";
                    question[1] = "90%";
                    question[2] = "10%";
                    question[3] = "50%";
                    question[4] = "25%";
                    question[5] = "4";
                    break;
                case 16:
                    question[0] = "The depletion of the ozone layer is not related to climate change, though many people mix up the two issues. What is the main cause of ozone depletion and the hole in the ozone layer?";
                    question[1] = "ZS3, or zelvecium sulfates, from cement manufacturing";
                    question[2] = "N20, or nitrous oxide, from the evaporation of nitrogen fertilizers used in intensive agriculture";
                    question[3] = "CH3, or methane, from soil degradation";
                    question[4] = "CFCs, or chlorofluorocarbons, substances used in refrigerants and aerosols";
                    question[5] = "3";
                    break;
                case 17:
                    question[0] = "Where is the hole in the Ozone layer?";
                    question[1] = "It moves, depending on the moon";
                    question[2] = "Over the North Pole";
                    question[3] = "Over Antarctica";
                    question[4] = "Over North America";
                    question[5] = "2";
                    break;
                case 18:
                    question[0] = "In 2010, the Cancun Agreement reconized countries' willingness to make sure the global average temperature won't rise beyond...";
                    question[1] = "10 degrees celcius";
                    question[2] = "4 degrees celcius";
                    question[3] = "2 degrees celcius";
                    question[4] = "1 degrees celcius";
                    question[5] = "1";
                    break;
                case 19:
                    question[0] = "When was the first time international leaders met with the purpose of discussing enviromental issues?";
                    question[1] = "1997 at the signature of the Kyoto Protocol";
                    question[2] = "1960 at the United Nations Summit on Enviromental Problems";
                    question[3] = "1992 at the United Nations Conference on Enviroment and Development";
                    question[4] = "1945 at the Potsdam Conference";
                    question[5] = "3";
                    break;
                case 20:
                    question[0] = "After Brazil, which country has the largest rainforest areas on the planet?";
                    question[1] = "India";
                    question[2] = "Papua New Guinea";
                    question[3] = "Colombia";
                    question[4] = "Indonesia";
                    question[5] = "2";
                    break;
                case 21:
                    question[0] = "One ton of writing paper roughly equates to how many trees worth of pulp?";
                    question[1] = "5 trees";
                    question[2] = "12 trees";
                    question[3] = "17 trees";
                    question[4] = "24 trees";
                    question[5] = "4";
                    break;
                case 22:
                    question[0] = "What is the name of the Island where Singapore's waste is buried?";
                    question[1] = "Pulau Tekong";
                    question[2] = "Pulau Ubin";
                    question[3] = "Pulau Semakau";
                    question[4] = "St John's Island";
                    question[5] = "3";
                    break;
                case 23:
                    question[0] = "What is the projected amount of rise in the sea level by 2100?";
                    question[1] = "1 to 2 meters";
                    question[2] = "0.6 to 1 meters";
                    question[3] = "0.2 to 0.6 meters";
                    question[4] = "0.1 to 0.2 meters";
                    question[5] = "3";
                    break;
                case 24:
                    question[0] = "How many square kilometers of the Amazon Forest have been deforested since 1970?";
                    question[1] = "250,000 square kilometers";
                    question[2] = "500,000 square kilometers";
                    question[3] = "750,000 square kilometers";
                    question[4] = "1,000,000 square kilometers";
                    question[5] = "3";
                    break;
                case 25:
                    question[0] = "What is the highest historical PSI value recorded in Singapore?";
                    question[1] = "100";
                    question[2] = "200";
                    question[3] = "300";
                    question[4] = "400";
                    question[5] = "4";
                    break;
                case 26:
                    question[0] = "How much of the coral reefs of the world have been destroyed?";
                    question[1] = "25%";
                    question[2] = "10%";
                    question[3] = "5%";
                    question[4] = "2.5%";
                    question[5] = "2";
                    break;
                case 27:
                    question[0] = "What percentage of the world's coral reefs are over-fished?";
                    question[1] = "80%";
                    question[2] = "60%";
                    question[3] = "25%";
                    question[4] = "10%";
                    question[5] = "1";
                    break;
            }

            return question;
        }

    }
}
