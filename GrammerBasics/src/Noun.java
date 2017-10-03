
public class Noun extends Grammer {
String noun;

public Noun(String noun) {
	super();
	this.noun = noun;
}

public String getNoun() {
	return noun;
}

public void setNoun(String noun) {
	this.noun = noun;
}

@Override
public String printSelf() {
	
	return noun;
}

@Override
public String toString() {
	return noun;
}

}
