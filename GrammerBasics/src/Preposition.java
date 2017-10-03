
public class Preposition extends Grammer {

	String prep;
	NounPhrase phrase; 
	public Preposition() {
		
	}
	public Preposition(String prep) {
		this.prep = prep;
	}
	public NounPhrase getPhrase() {
		return phrase;
	}
	public void setPhrase(NounPhrase phrase) {
		this.phrase = phrase;
	}
	public String getPrep() {
		return prep;
	}
	public void setPrep(String prep) {
		this.prep = prep;
	}
	@Override
	public String printSelf() {
		
		return prep;
	}
	@Override
	public String toString() {
		return prep + " "+ phrase.toString();
	}
	

}
