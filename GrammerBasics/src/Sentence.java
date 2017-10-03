
public class Sentence extends Grammer {
	NounPhrase nounPhrase;
	VerbPhrase verbPhrase;
	public NounPhrase getNounPhrase() {
		return nounPhrase;
	}
	public void setNounPhrase(NounPhrase nounPhrase) {
		this.nounPhrase = nounPhrase;
	}
	public VerbPhrase getVerbPhrase() {
		return verbPhrase;
	}
	public void setVerbPhrase(VerbPhrase verbPhrase) {
		this.verbPhrase = verbPhrase;
	}
	@Override
	public String printSelf() {
		return "";
		// TODO Auto-generated method stub
		//nothing
	}
	@Override
	public String toString() {
		return nounPhrase.toString() +" "+ verbPhrase.toString();
	}
}
