
public class Article extends Grammer {

String art;

public Article(String art) {
	super();
	this.art = art;
}

public String getArt() {
	return art;
}

public void setArt(String art) {
	this.art = art;
}

@Override
public String printSelf() {
	
	return art;
}
@Override
public String toString() {
	return art;
}
}
