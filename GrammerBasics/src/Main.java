import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;
import java.util.Stack;

public class Main {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		Stack<Sentence> responseStack = new Stack<Sentence>();
		while(true)
		{
			System.out.println("Please state a Phrase.");
			Stack<Object> stack = new Stack<Object>();
//			String phrase = "The dog bites the cat";
			String phrase = scan.nextLine();
			String[]  groups= phrase.split(" ");
			
			for(int i = 0; i < groups.length; i++)
			{
				stack.push(groups[i]);
				while(!stack.isEmpty() && !(stack.peek() instanceof  Sentence))
				{
					//how to account for size
					Object top = stack.pop();
					
					if(top instanceof  VerbPhrase && !stack.isEmpty() && stack.peek() instanceof NounPhrase)
					{
						Sentence sentence = new Sentence();
						sentence.setNounPhrase((NounPhrase)stack.peek());
						sentence.setVerbPhrase((VerbPhrase)top);
						stack.pop(); // get rid of the NounPhrase
						stack.push(sentence);
					}else if(top instanceof Noun && !stack.isEmpty() && stack.peek() instanceof Article && ((i + 1) >= groups.length || !groups[i+1].equals("with")))
					{
						NounPhrase nounPhrase = new NounPhrase();
						nounPhrase.setAtricle((Article)stack.peek());
						nounPhrase.setNoun((Noun)top);
						stack.pop(); // get rid of Article
						stack.push(nounPhrase);
					}else if(checkPrep(top, stack))//here change
					{
						NounPhrase nounPhrase = new NounPhrase();
						Preposition prep = (Preposition)stack.pop();
						nounPhrase.setNoun((Noun)stack.pop());
						nounPhrase.setAtricle((Article)stack.pop());
						
						prep.setPhrase((NounPhrase)top);
						nounPhrase.setPrep(prep);
						
						stack.push(nounPhrase);
					}else if(top instanceof Verb && ((i + 1) >= groups.length || !Arrays.asList("a", "the", "dog", "cat", "fish").contains((groups[i+1]) )))
					{
						VerbPhrase verbPhrase = new VerbPhrase();
						//Verb verb = new Verb((String)top);
						verbPhrase.setVerb((Verb)top);
						stack.push(verbPhrase);
					}else if(top instanceof NounPhrase && !stack.isEmpty() && stack.peek() instanceof Verb)
					{
						VerbPhrase verbPhrase = new VerbPhrase();
						verbPhrase.setVerb((Verb)stack.pop());
						verbPhrase.setNounPhrase((NounPhrase)top);
						stack.push(verbPhrase);
					}else if(top instanceof String)
					{
						String word = (String)top;
						if(word.equals("a")||word.equalsIgnoreCase("the"))
						{
							Article art  = new Article(word);
							stack.push(art);
						}else if(word.equals("dog")||word.equals("cat")||word.equals("fish") )
						{
							Noun noun = new Noun(word);
							stack.push(noun);
						}else if(word.equals("with"))
						{
							Preposition noun = new Preposition(word);
							stack.push(noun);
						}else if(word.equals("bites")||word.equals("chases"))
						{
							Verb verb = new Verb(word);
							stack.push(verb);
						}
					}else if(top instanceof String && !stack.isEmpty() && stack.peek() instanceof NounPhrase)
					{
						Preposition prep = new Preposition();
						prep.setPrep((String)stack.peek());
						prep.setPhrase((NounPhrase)top);
					}
					else {
						stack.push(top);
						break;
					}
				}
			}
			
			String reply ="Why does ";
			if(stack.isEmpty())
			{
				if(responseStack.isEmpty())
				{
					System.out.println("I don't understand that.");
				}
				else
				{
					Sentence sent = responseStack.pop();
					System.out.println(Response() + sent.toString());
				}
			}
			else
			{
				Object end = stack.pop();
				if(end instanceof Sentence)
				{
					Sentence sentence  = (Sentence)end;
					responseStack.push(sentence);
					System.out.println(reply + sentence.toString());
				}
				else
				{
					if(responseStack.isEmpty())
					{
						System.out.println("I don't understand that.");
					}
					else
					{
						Sentence sent = responseStack.pop();
						System.out.println(Response() + sent.toString());
					}
				}
			}
			
		}

	}
	
	public static boolean checkPrep(Object top,Stack<Object> stack)
	{
		if(stack.empty())
		{
			return false;
		}
		Object piece2 = stack.pop();//only comes off if not empty
		if(stack.empty())
		{
			stack.push(piece2);
			return false;
		}
		Object piece3 = stack.pop();//only comes off if not empty
		if(stack.empty())
		{
			stack.push(piece3);
			stack.push(piece2);
			return false;
		}
		Object piece4 = stack.pop();//only comes off if not empty
		boolean passed = false;
		if(top instanceof NounPhrase && piece2 instanceof Preposition && piece3 instanceof Noun &&  piece4 instanceof Article )
		{
			passed = true;
		}
		stack.push(piece4);
		stack.push(piece3);
		stack.push(piece2);
		return passed;
	}
	public static String Response()
	{
		String res = "";
		Random rand = new Random();
		int num = rand.nextInt(4)+1;
		switch(num)
		{
		case 1:
			res = "Why do ";
			break;
		case 2:
			res = "How often does";
			break;
		case 3:
			res = "In what way does ";
			break;
		case 4:
			res = "Do you like ";
			break;
			default:
				res ="To many cases ";
				break;
		}
		return res;
	}
}
