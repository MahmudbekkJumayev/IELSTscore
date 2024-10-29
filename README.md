# IELTS Score Calculator

This project calculates the overall IELTS score based on the user's input scores for Speaking, Reading, Listening, and Writing. The final score is rounded according to IELTS rules.

## Features
- Input individual scores for each section
- Calculate the average score
- Round the score to the nearest half or whole number as per IELTS rounding rules


## project code 

![Screenshot of the Code](https://carbon.now.sh/?bg=rgba%28171%2C+184%2C+195%2C+1%29&t=seti&wt=none&l=text%2Fx-csharp&width=680&ds=true&dsyoff=20px&dsblur=68px&wc=true&wa=true&pv=56px&ph=56px&ln=false&fl=1&fm=Hack&fs=14px&lh=133%25&si=false&es=2x&wm=false&code=decimal%2520%255B%255D%2520ielstScore%2520%253D%2520new%2520decimal%255B4%255D%253B%250A%250AConsole.Write%28%2522Speaking%2520score%2520%285.5%29%253A%2520%2522%29%253B%250Astring%2520speakingInput%2520%253D%2520Console.ReadLine%28%29%253B%250AielstScore%255B0%255D%2520%253D%2520Convert.ToDecimal%28speakingInput%29%253B%250A%250AConsole.Write%28%2522Reading%2520score%2520%285.5%29%253A%2520%2522%29%253B%250Astring%2520readingInput%2520%253D%2520Console.ReadLine%28%29%253B%250AielstScore%2520%255B1%255D%2520%253D%2520Convert.ToDecimal%28readingInput%29%253B%250A%250AConsole.Write%28%2522Listening%2520score%2520%285.5%29%253A%2520%2522%29%253B%250Astring%2520listeningInput%2520%253D%2520Console.ReadLine%28%29%253B%250AielstScore%2520%255B2%255D%2520%253D%2520Convert.ToDecimal%28listeningInput%29%253B%250A%250AConsole.Write%28%2522Writing%2520score%2520%285.5%29%253A%2520%2522%29%253B%250Astring%2520writingInput%2520%253D%2520Console.ReadLine%28%29%253B%250AielstScore%2520%255B3%255D%2520%253D%2520Convert.ToDecimal%28writingInput%29%253B%250A%250A%250Adecimal%2520avarageScore%2520%253D%2520ielstScore.Average%28%29%253B%250Aint%2520avarageInt%2520%253D%2520%28int%29avarageScore%253B%250Adecimal%2520remender%2520%253D%2520avarageScore%2520-%2520avarageInt%253B%250A%250Aif%28remender%2520%253C%25200.25m%29%257B%250A%2520%2520%2520%2520remender%2520%253D%25200%253B%250A%257Delse%2520if%28remender%2520%253C%25200.75m%29%257B%250A%2520%2520%2520%2520remender%2520%253D%25200.5m%253B%250A%257Delse%2520%257B%250A%2520%2520%2520%2520remender%2520%253D%25201%253B%250A%257D%250A%250AavarageScore%2520%253D%2520avarageInt%2520%252B%2520remender%253B%250A%250AConsole.Write%28%2524%2522%2520Your%2520IELST%2520socre%2520overall%2520%253A%2520%257BavarageScore%257D%2522%29%253B)
