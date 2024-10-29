decimal [] ielstScore = new decimal[4];

Console.Write("Speaking score (5.5): ");
string speakingInput = Console.ReadLine();
ielstScore[0] = Convert.ToDecimal(speakingInput);

Console.Write("Reading score (5.5): ");
string readingInput = Console.ReadLine();
ielstScore [1] = Convert.ToDecimal(readingInput);

Console.Write("Listening score (5.5): ");
string listeningInput = Console.ReadLine();
ielstScore [2] = Convert.ToDecimal(listeningInput);

Console.Write("Writing score (5.5): ");
string writingInput = Console.ReadLine();
ielstScore [3] = Convert.ToDecimal(writingInput);


decimal avarageScore = ielstScore.Average();
int avarageInt = (int)avarageScore;
decimal remender = avarageScore - avarageInt;

if(remender < 0.25m){
    remender = 0;
}else if(remender < 0.75m){
    remender = 0.5m;
}else {
    remender = 1;
}

avarageScore = avarageInt + remender;

Console.Write($" Your IELST socre overall : {avarageScore}");