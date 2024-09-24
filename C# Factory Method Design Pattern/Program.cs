using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections.Generic;

namespace C__Factory_Method_Design_Pattern
{
 
        /// <summary>
        /// MainApp startup class for Real-World 
        /// Factory Method Design Pattern.
        /// </summary>

        class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>

            static void Main()
            {
                // Note: constructors call Factory Method

                Document[] documents = new Document[2];

                documents[0] = new Resume();
                documents[1] = new Report();

                // Display document pages

                foreach (Document document in documents)
                {
                    Console.WriteLine("\n" + document.GetType().Name + "--");
                    foreach (Page page in document.Pages)
                    {
                        Console.WriteLine(" " + page.GetType().Name);
                    }
                }

                // Wait for user

                Console.ReadKey();
            }
        }

        /// <summary>
        /// The 'Product' abstract class
        /// </summary>

        abstract class Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class SkillsPage : Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class EducationPage : Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class ExperiencePage : Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class IntroductionPage : Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class ResultsPage : Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class ConclusionPage : Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class SummaryPage : Page
        {
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>

        class BibliographyPage : Page
        {
        }

        /// <summary>
        /// The 'Creator' abstract class
        /// </summary>

       

        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>

        

        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>

        class Report : Document
        {
            // Factory Method implementation

            public override void CreatePages()
            {
                Pages.Add(new IntroductionPage());
                Pages.Add(new ResultsPage());
                Pages.Add(new ConclusionPage());
                Pages.Add(new SummaryPage());
                Pages.Add(new BibliographyPage());
            }
        }
    }


  