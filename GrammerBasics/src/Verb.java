
public class Verb extends Grammer{
String verb;

public String getVerb() {
	return verb;
}

public void setVerb(String verb) {
	this.verb = verb;
}

public Verb(String verb) {
	super();
	this.verb = verb;
}

@Override
public String printSelf() {
	
	return verb;
}

@Override
public String toString() {
	return verb;
}

}
