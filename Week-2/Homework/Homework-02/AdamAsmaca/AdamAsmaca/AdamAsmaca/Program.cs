using System;

namespace AdamAsmaca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 1. Bir kelime grubundan rastgele bir kelime seç. (ayna)
             * 2. Seçtiğin bu kelimenin her harfini * işaretine dönüştür ve ekranda göster. (****)
             * 3. Bu bulmacayı ekranda göster. (****)
             * 4. Oyuncudan harf iste
             * 5. Harf kelimede var mı kontrol et.
             * 6. a. Eğer varsa, o harfin bulunduğu * işaretlerini harfe çevir (a**a)
             *    b. Yoksa bir hakkını azalt
             * 7. Oyuncudan kelimeyi tahmin etmesini iste
             *    Bilirse oyunu bitir.
             *    Bilemezse 3. adıma dön
             */
            string[] words = { "ayna", "masa", "tarantula", "endoplazmikretikulum" };
            bool isGameOver = false;
            while (!isGameOver)
            {
                int point = 10;
                string selectedWord = chooseWord(words);
                string puzzle = replaceToStar(selectedWord);
                Console.WriteLine(puzzle);
                bool isWordFinding = false;
                while (!isWordFinding)
                {
                    Console.WriteLine("Bir harf giriniz.");
                    string letter = Console.ReadLine();
                    bool isLetterExistInWord = checkLetterInWord(selectedWord, letter);
                    if (isLetterExistInWord)
                    {
                        puzzle = replaceStarToLetter(selectedWord, puzzle, letter);
                        Console.WriteLine(puzzle);
                    }
                    
                    Console.WriteLine("Kelimeyi tahmin etmek ister misin? (E/H)");
                    string answerForGuess = Console.ReadLine();
                    if (answerForGuess.ToUpper() == "E")
                    {
                        Console.WriteLine("Tahmininizi Giriniz:");
                        string guess = Console.ReadLine();
                        isWordFinding = compareGuessAndSelectedWord(guess, selectedWord);
                        if (!isWordFinding & point>0)
                        {
                            Console.WriteLine("Tahmininiz yanlış.");
                            point -= 1;
                            Console.WriteLine($"{point} deneme hakkınız kaldı.");
                        }
                    } 
                }

                Console.WriteLine("Oyuna Devam Mı ?(E/H)");
                isGameOver = Console.ReadLine().ToUpper() == "H";
            }
        }

       







        /// <summary>
        /// Bu metod ile kelimelerin bulunduğu koleksiyondan rastgele bir kelime seçersiniz.
        /// </summary>
        /// <param name="words">Dizi</param>
        /// <returns></returns>
        static string chooseWord(string[] words)
        {
            Random random = new Random();
            string word = words[random.Next(0, words.Length)];
            return word;
        }

        /// <summary>
        /// Bu method ile seçilen kelimeyi * lara dönüştürürsünüz.
        /// </summary>
        /// <param name="selectedWord">Seçilen Kelime</param>
        /// <returns></returns>
        private static string replaceToStar(string selectedWord)
        {
            string puzzleResult = string.Empty;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                puzzleResult += "*";
            }
            return puzzleResult;
        }

        /// <summary>
        /// Bu metod ile bir kelimede bir harf olup olmadığını bulursunuz
        /// </summary>
        /// <param name="selectedWord">Kaynak Kelime</param>
        /// <param name="letter">Aranacak Harf</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static bool checkLetterInWord(string selectedWord, string letter)
        {
            return selectedWord.Contains(letter);
        }

        private static string replaceStarToLetter(string selectedWord, string puzzle, string letter)
        {
            int startIndex = 0;
            char[] puzzleStars = puzzle.ToCharArray();
            while(selectedWord.IndexOf(letter,startIndex)!=-1)
            {
                int findingIndex = selectedWord.IndexOf(letter,startIndex);
                puzzleStars[findingIndex] = Convert.ToChar(letter);
                startIndex = findingIndex + 1;
            }
            string result = string.Empty;
            foreach (var item in puzzleStars)
            {
                result += item.ToString();
            }
            return result;
        }

        private static bool compareGuessAndSelectedWord(string guess, string selectedWord)
        {
            return guess == selectedWord;
        }

    }
}
