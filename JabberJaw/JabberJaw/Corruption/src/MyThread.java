
public class MyThread extends Thread{
	public static int x = 0;
	@Override
	public void run()
	{
		//System.out.println(Thread.currentThread().getId());
		int local = x; 
		local++;
		x = local;
		System.out.println("Static x: "+ x);
	}
}