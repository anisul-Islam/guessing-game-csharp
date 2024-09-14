class Program
{
  public static void Main(string[] args)
  {
    // step 1: Generate the random number from 1 to 6
    Random random = new Random();
    int randomNumber = random.Next(1, 6);


    int numberOfAttempts = 0;
    bool isCorrectGuess = false;
    Console.WriteLine($"Welcome to the Number Guessing Game!");

    // step 2: start the guessing loop
    while (!isCorrectGuess)
    {

      // step 3: prompt the user to enter the guess
      Console.Write($"Enter your guess between (1-6): ");
      bool isValidNumber = int.TryParse(Console.ReadLine(), out int guessNumber);


      // validate the user input
      if (!isValidNumber || guessNumber < 1 || guessNumber > 6)
      {
        Console.WriteLine($"Please eneter a valid number between 1 and 6");
        continue;
      }

      numberOfAttempts++;

      // step 4: use switch statement to handle the comparsion between guessNumber and randomNumber 
      switch (guessNumber)
      {
        case var _ when guessNumber > randomNumber:
          Console.WriteLine($"Too high! Try again.");
          break;
        case var _ when guessNumber < randomNumber:
          Console.WriteLine($"Too Low! Try again.");
          break;
        case var _ when guessNumber == randomNumber:
          Console.WriteLine($"Congratulations! You've guessed the correct number {guessNumber} in {numberOfAttempts} attempts.");
          isCorrectGuess = true;
          break;
      }
    }
  }
}