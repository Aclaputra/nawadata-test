split-word: 
	mcs -out:split-world.exe SplitWord.cs; 
	mono split-world.exe

max-num: 
	mcs -out:max-num.exe MaxNum.cs; 
	mono max-num.exe

sort-num:
	mcs -out:sort-num.exe SortNum.cs;
	mono sort-num.exe

most-letter:
	mcs -out:most-letter.exe MostLetter.cs;
	mono most-letter.exe

run:
	make split-word;
	make max-num;
	make sort-num;
	make most-letter