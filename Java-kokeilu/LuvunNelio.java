import java.io.*;

public class LuvunNelio {
	public static void main(String[] args) {
		int luku;
		int luvun_nelio;

		BufferedReader in = new BufferedReader(new InputStreamReader(System.in));

		try {
			System.out.print("Syötä kokonaisluku: ");
			luku = Integer.parseInt(in.readLine());
   
			luvun_nelio = luku * luku;
			System.out.println("Antamasi luvun neliö: " + luvun_nelio);

		} catch(Exception e) {
			System.out.println("Antamasi syöte oli virheellinen...");
		}
	}
}
