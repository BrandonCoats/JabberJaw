
public class VerbPhrase extends Grammer{
Verb verb;
public Verb getVerb() {
	return verb;
}
public void setVerb(Verb verb) {
	this.verb = verb;
}
public NounPhrase getNounPhrase() {
	return nounPhrase;
}
public void setNounPhrase(NounPhrase nounPhrase) {
	this.nounPhrase = nounPhrase;
}
NounPhrase nounPhrase;
@Override
public String printSelf() {
	return "";
	// TODO Auto-generated method stub
	//do nothing
}
@Override
public String toString() {
	if(nounPhrase == null)
	{
		return verb.toString();
	}
	else
	{
		return verb.toString() +" "+ nounPhrase.toString();
	}
}

}
