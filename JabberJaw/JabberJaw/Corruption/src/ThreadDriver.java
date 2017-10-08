
public class ThreadDriver {

	public static void main(String[] args) throws InterruptedException {
		MyThread t = new MyThread();
		MyThread t2 = new MyThread();
		t.start();
		t2.start();

	}

}
