print("Welcome\nIt's a Stone-Paper-Scissor Game")
while True:
      import random
      computer= random.choice([-1, 0, 1])
      youint=int(input("[1 for Stone, 0 for Paper, -1 for Scissor]\nEnter your choice:"))
      youstr=str(input("Enter any key to continue or\nEnter 'quit' to leave the game:"))
      youDict= {1:"Stone", 0:"Paper", -1: "Scissor"}
      reverseDict= {"Stone":1, "Paper":0, "Scissor":-1}
      you=youint

      try:
        youint = int(youint)
      except KeyError:
        print("ERROR: Invalid input. Please enter a number or 'stop' to quit.")
        continue
      if youint not in youDict:
        input("ERROR: Invalid choice.\nPlease enter 1, 0, or -1:")
        continue       
      print(f"You Chose={youDict[you]}\nComputer Chose={youDict[computer]}")
    
      if (computer==you):
         print("Draw\n")
      else:
         if (computer==1 and you==0):
               print("You Won\n")
         elif (computer==1 and you==-1):
               print("You Lose\n")
         elif (computer==0 and you==-1):
               print("You Won\n")
         elif (computer==0 and you==1):
               print("You Lose\n")
         elif (computer==-1 and you==1):
               print("You Won\n")
         elif (computer==-1 and you==0):
               print("You Lose\n")
         else:
               print("ERORR\n")
               
      if youstr.lower()=='quit':
           break
      else:
           continue

   