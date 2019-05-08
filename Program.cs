using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace ringba_test
{
    class Program
    {

        static void Main(string[] args)
        {
            //Intro console text:

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Ringba Junior Developer Code Test -- Coded by Danny Alig");
            Console.WriteLine();
            Console.WriteLine("Importing output.txt...");
        

            //Download and read output.txt into string:
            
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://ringba-test-html.s3-website-us-west-1.amazonaws.com/TestQuestions/output.txt");
            StreamReader reader = new StreamReader(stream);
            string rawString= reader.ReadToEnd();


            //Import complete notification then ReadKey to begin computation:
            
            Console.WriteLine();
            Console.WriteLine("Import complete!");
            Console.WriteLine();
            Console.WriteLine("Press any key to begin output.txt analysis");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Analysis in progress...");
            Console.WriteLine();

            
            //Assigning array from string, sorting array alphabetically, computing string and array length:

            int stringLength = rawString.Length;

            string upperCaseString = rawString.ToUpper();

            string[] rawArray =  Regex.Split(rawString, @"(?<!^)(?=[A-Z])");

            Array.Sort(rawArray);

            int arrLength = rawArray.Length;


            //Variable Initializations:
    
            int i;
            int j;
            string tempWord;
            string lastWord="";
            string tempPrefix;
            string currPrefix;
            string lastPrefix="";
            int tempWordCount=1;
            int kingWordCount=0;
            string kingWord= "none";
            int tempPrefixCount=0;
            int kingPrefixCount=0;
            string kingPrefix="none";
            string tempPrefixList="";
            string kingPrefixList="";
            int Acount=0;
            int Bcount=0;
            int Ccount=0;
            int Dcount=0;
            int Ecount=0;
            int Fcount=0;
            int Gcount=0;
            int Hcount=0;
            int Icount=0;
            int Jcount=0;
            int Kcount=0;
            int Lcount=0;
            int Mcount=0;
            int Ncount=0;
            int Ocount=0;
            int Pcount=0;
            int Qcount=0;
            int Rcount=0;
            int Scount=0;
            int Tcount=0;
            int Ucount=0;
            int Vcount=0;
            int Wcount=0;
            int Xcount=0;
            int Ycount=0;
            int Zcount=0;


        //Process each letter of string through switch to find letter counts:

            for (i=0;i<stringLength; i++){

                switch(upperCaseString[i]){
                    case 'A':
                    Acount++;
                    break;
                    case 'B':
                    Bcount++;
                    break;
                    case 'C':
                    Ccount++;
                    break;
                    case 'D':
                    Dcount++;
                    break;
                    case 'E':
                    Ecount++;
                    break;
                    case 'F':
                    Fcount++;
                    break;
                    case 'G':
                    Gcount++;
                    break;
                    case 'H':
                    Hcount++;
                    break;
                    case 'I':
                    Icount++;
                    break;
                    case 'J':
                    Jcount++;
                    break;
                    case 'K':
                    Kcount++;
                    break;
                    case 'L':
                    Lcount++;
                    break;
                    case 'M':
                    Mcount++;
                    break;
                    case 'N':
                    Ncount++;
                    break;
                    case 'O':
                    Ocount++;
                    break;
                    case 'P':
                    Pcount++;
                    break;
                    case 'Q':
                    Qcount++;
                    break;
                    case 'R':
                    Rcount++;
                    break;
                    case 'S':
                    Scount++;
                    break;
                    case 'T':
                    Tcount++;
                    break;
                    case 'U':
                    Ucount++;
                    break;
                    case 'V':
                    Vcount++;
                    break;
                    case 'W':
                    Wcount++;
                    break;
                    case 'X':
                    Xcount++;
                    break;
                    case 'Y':
                    Ycount++;
                    break;
                    case 'Z':
                    Zcount++;
                    break;
                    
                }
            }


        // Process through sorted array to find most common prefix and word
        
            for(i=0; i<arrLength; i++){

                tempWord = rawArray[i];

                if(rawArray[i].Length>=2){
                tempPrefix = rawArray[i].Substring(0,2);
                }else{
                    tempPrefix=tempWord;
                }
    
                if(tempPrefix!=lastPrefix){
                    tempPrefixCount=0;
                    tempPrefixList="";

                    for(j=i; j<arrLength; j++){


                        if(rawArray[j].Length>=2){
                            currPrefix = rawArray[j].Substring(0,2);
                        }else{
                            currPrefix=rawArray[j];
                        }

                        if(tempPrefix!=currPrefix){
                            break;
                        } else

                        if(rawArray[j].Length>2){
                            tempPrefixCount++;
                            tempPrefixList += (rawArray[j]+", ");

                            if(tempPrefixCount>kingPrefixCount){
                                kingPrefixCount=tempPrefixCount;
                                kingPrefix=tempPrefix;
                                kingPrefixList=tempPrefixList;
                            }
                        }

                        
                    }   

                } 
  
                if(tempWord==lastWord){
                    tempWordCount++;

                    if (tempWordCount>kingWordCount){
                    kingWordCount = tempWordCount;
                    kingWord=tempWord;
                    }

                } else {
                    tempWordCount=1;
                }
                
                lastPrefix=tempPrefix;
                lastWord=tempWord;

            }



        //Removes last comma and space from prefix list string:

        kingPrefixList = kingPrefixList.Substring(0, kingPrefixList.Length-2);


        //Final console printing of results:

            Console.WriteLine("Analysis complete!");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Letter Count:");
            Console.WriteLine();
            Console.WriteLine("A:"+Acount+" B:"+Bcount+" C:"+Ccount+" D:"+Dcount+" E:"+Ecount+" F:"+Fcount);
            Console.WriteLine("G:"+Gcount+" H:"+Hcount+" I:"+Icount+" J:"+Jcount+" K:"+Kcount+" L:"+Lcount);
            Console.WriteLine("M:"+Mcount+" N:"+Ncount+" O:"+Ocount+" P:"+Pcount+" Q:"+Qcount+" R:"+Rcount);
            Console.WriteLine("S:"+Scount+" T:"+Tcount+" U:"+Ucount+" V:"+Vcount+" W:"+Wcount+" X:"+Xcount);
            Console.WriteLine("Y:"+Ycount+" Z:"+Zcount);
            Console.WriteLine();
            Console.WriteLine("Capitalized Letters (Word Count): "+arrLength);
            Console.WriteLine();
            Console.WriteLine("Most Common Word: "+kingWord+", which appeared "+kingWordCount+" times");
            Console.WriteLine();
            Console.WriteLine("Most Common 2-character prefix: '"+kingPrefix+"', which occurred "+kingPrefixCount+" times");
            Console.WriteLine();
            //Need this ReadKey because the list eats up the console otherwise!
            Console.WriteLine("Press any key to display '"+kingPrefix+"' word list...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Words starting with prefix '"+kingPrefix+"'--");
            Console.WriteLine(kingPrefixList);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

        }
    }
}

//Coded by Danny Alig for Ringba Junior Developer Code Test, originally submitted 4/5/19. dannyalig@gmail.com
//Updated 4/6/19: Slightly more lines of code than original, now has user updates for better UX.