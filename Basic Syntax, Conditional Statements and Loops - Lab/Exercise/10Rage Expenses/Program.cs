int lostGameCnt = int.Parse(Console.ReadLine());
decimal headSetPr = decimal.Parse(Console.ReadLine());
decimal mousePr = decimal.Parse(Console.ReadLine());
decimal keyboardPr=decimal.Parse(Console.ReadLine());
decimal displayPr = decimal.Parse(Console.ReadLine());
int keyBoardTrashCnt = 0;
int headsedTrashCnt = 0;
int mousesedTrashCnt = 0;
int displayTrashCnt = 0;
int totalCnt = 0;
for (int i = 1; i <= lostGameCnt; i++)
{
	if (i%2==0)
	{
		headsedTrashCnt++;
	}
	if (i%3==0)
	{
		mousesedTrashCnt++;
		if (i%2==0 && i%3==0)
		{
            keyBoardTrashCnt++;
            if (keyBoardTrashCnt % 2 == 0)
            {
                displayTrashCnt++;
            }
        }
        
	}
}
decimal totalPrice = displayTrashCnt*displayPr + keyboardPr*keyBoardTrashCnt + mousesedTrashCnt*mousePr + headSetPr*headsedTrashCnt;
Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");

