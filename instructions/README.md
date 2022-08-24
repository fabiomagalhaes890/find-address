## Question 

You're a famous detective and you've been called into town to solve a case. Seems like this particular criminal left clues to his next victim. The clues say the next location the criminal will attack is Cross Street but there is no address. The police don't seem too interested in figuring out the clue and the commissioner seems to be ignoring you and went to the rooftop. On a USB drive you've found a document with a large list of numbers and in several different places you've found clues as to what the numbers mean. You've figured out the following.

Each line represents a command.

Commands starting with 20 increase the "address" variable. For example:
- Command 201 increases the address variable by 1.
- Command 2010 increases the address variable by 10.

Commands starting with 5 jump to another command. For example:
- Command 51 executes the next instruction.
- Command 52 ignores the next instruction and executes the one after.
- Command 510 jumps 10 instructions forward.

Commands starting with any other digit do nothing and the next command is executed in succession.

The program starts at the first number and ends once there is no command left to be executed.

Assuming the address starts at zero and given the input document (commands.txt), what is the value of the address variable when the document ends? `The value of address is 670`

Example:  
25  
52  
53  
202  
54  
402  
203  
510  
201  

Starting from 25.  
25 is not a known command. So nothing is done.  
52 jumps two ahead to 202.  
202 increases the address variable by 2.  
54 jumps ahead to 201  
201 increases the address variable by 1.  
There is no longer a command to execute so the result is that the address is 3.  