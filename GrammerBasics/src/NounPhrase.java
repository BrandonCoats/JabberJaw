
public class NounPhrase extends Grammer {
Article atricle;
Noun noun;
Preposition prep;
public Preposition getPrep() {
	return prep;
}
public void setPrep(Preposition prep) {
	this.prep = prep;
}
public Article getAtricle() {
	return atricle;
}
public void setAtricle(Article atricle) {
	this.atricle = atricle;
}
public Noun getNoun() {
	return noun;
}
public void setNoun(Noun noun) {
	this.noun = noun;
}
@Override
public String printSelf() {
	return "";
	//do nothing
	
}
@Override
public String toString() {
	if(prep == null)
	{
		return atricle.toString() +" "+noun.toString();
	}
	else
	{
		return atricle.toString() +" "+noun.toString()+" "+ prep.toString();
	}
}

}
