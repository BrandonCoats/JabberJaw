
public abstract class Database {
	
	public abstract String getUserById(int id);
	public abstract boolean userIsinDatabase(String username);
	//attached to a different database just for users 
	//database: sql: Users
	public abstract String getAnswerByNoun(String noun);
	//get the answer by a noun that is passed in ? neccessay?
	public abstract String getAnswerByRating();
	//decide in here the highest answer
	

}
